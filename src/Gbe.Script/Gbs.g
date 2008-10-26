grammar Gbs;

options 
{
	language=CSharp2;
	output=AST;
}

@parser::namespace 
{ 
	Gbe.Script 
}

@parser::header 
{
using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Script.Actions;
using Action = Gbe.Script.Actions.Action;
using Gbe.Script.Classdefs;
using Gbe.Script.Formulas;
using Gbe.Script.Parameters;
using Gbe.Script.Triggers;
}

@lexer::namespace 
{ 
	Gbe.Script 
}

// LEXER

THIS
	:	'this'
	;

CLASSDEF_ENGINE	
	:	'ENGINE'
	;

CLASSDEF_PLAYER	
	:	'PLAYER'
	;

CLASSDEF_BULLET
	:	'BULLET'
	;

CLASSDEF_ENEMY	
	:	'ENEMY'
	;
	
CLASSDEF_SCRIPT
	:	'SCRIPT'
	;
	
CLASSDEF_STATE
	:	'STATE'
	;
	
CLASSDEF_EVENT
	:	'EVENT'
	;

PARAM_FPS	
	:	'fps'
	;
	
PARAM_GAMEAREA
	:	'gameArea'
	;
	
PARAM_POSITION
	:	'position'
	;
	
PARAM_COLOR
	:	'color'
	;
	
PARAM_SPEED
	:	'speed'
	;
	
PARAM_ANIMATION
	:	'animation'
	;
	
PARAM_SCROLLING
	:	'scrolling'
	;

ACTION_PERIODIC
	:	'.periodic'
	;
	
ACTION_FIRE
	:	'.fire'
	;

ACTION_DIE
	:	'.die'
	;

ACTION_START
	:	'.start'
	;

ACTION_STOP
	:	'.stop'
	;

ACTION_SUMMON
	:	'.summon'
	;
	
ACTION_PLAY_ANIMATION
	:	'.playAnimation'
	;
	
ACTION_SET
	:	'.set'
	;
	
ACTION_RAISE
	:	'.raise'
	;
	
TRIGGER_INIT
	:	'@init'
	;
	
TRIGGER_CLEANUP
	:	'@cleanup'
	;
	
TRIGGER_TIME
	:	'@time'
	;
	
TRIGGER_PERIODIC
	:	'@periodic'
	;

TRIGGER_SCROLLING
	:	'@scrolling'
	;
	
TRIGGER_ANIMATION_END
	:	'@animationEnd'
	;
	
TRIGGER_EVENT
	:	'@event'
	;

PREDEF_ANGLE_TOWARD_PLAYER
	:	'$player'
	;
	
CONST_ANGLE_DOWN
	:	'$DOWN'
	;

CONST_ANGLE_UP
	:	'$UP'
	;

CONST_ANGLE_LEFT
	:	'$LEFT'
	;

CONST_ANGLE_RIGHT
	:	'$RIGHT'
	;

COLOR
	:	'black'
	|	'white'
	|	'red'
	|	'green'
	|	'blue'
	|	'yellow'
	|	'pink'
	|	'lightblue'
	|	'#' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
	;

DIRECTION
	:	CARDINAL_DIRECTION ( ( '+' | '-' ) NUMBER )?
	;

fragment CARDINAL_DIRECTION
	:	'up'
	|	'down'
	|	'left'
	|	'right'
	;

NUMBER 
	:	( '+' | '-' )? ( ( DIGIT+ ( '.' DIGIT* )? ) | ( '.' DIGIT+ ) )
	;

fragment HEX_DIGIT
	:	DIGIT | 'A'..'F' | 'a'..'f'
	;

fragment DIGIT
	:	'0'..'9'
	;

POINT
	:	NUMBER ':' NUMBER
	;
	
RECTANGLE
	:	POINT '->' POINT
	;
	
CLASS_IDENTIFIER
	:	'A'..'Z' ( 'a'..'z' | 'A'..'Z' | '0'..'9' )*
	;
	
INSTANCE_IDENTIFIER
	:	'a'..'z' ( 'a'..'z' | 'A'..'Z' | '0'..'9' )*
	;
	
STRING
	:	'"' ( options { greedy=false; } : . )* '"'
	;

WHITESPACE 
	: ( '\t' | ' ' | '\r' | '\n'| '\u000C' )+ 	{ $channel = HIDDEN; }
	;

ML_COMMENT 
	: '/*' ( options { greedy=false; } : . )* '*/'	{ $channel = HIDDEN; }
	;
	
SL_COMMENT
	: '//' ( options { greedy=false; } : . )* '\n'  { $channel = HIDDEN; }
	;
	
// PARSER
	
gbs returns [Gbs s]
scope 
{ 
	List<Classdef> classdefs; 
}
@init 
{ 
	$gbs::classdefs = new List<Classdef>(); 
} 
	:	classdef* { $s = new Gbs($gbs::classdefs); }
	;

formula returns [Formula formula]
scope 
{ 
	List<bool> add; 
	List<Formula> terms;
}
@init 
{ 
	$formula::add = new List<bool>();
	$formula::terms = new List<Formula>();
} 
	:	a=factor_formula ( '+' b=factor_formula { $formula::add.Add(true); $formula::terms.Add($b.formula); } | '-' b=factor_formula { $formula::add.Add(false); $formula::terms.Add($b.formula); } )* { $formula = new RawSumFormula($a.formula, $formula::add, $formula::terms); }
	;
	
factor_formula returns [Formula formula]
	:	a=simple_formula ( '*' b=simple_formula )* //{ $formula = new MultiplyFormula(r.range, $b.formula); }
	;

simple_formula returns [Formula formula]
	:	c=NUMBER { $formula = new ConstValueFormula(float.Parse($c.Text)); }
	|	c=NUMBER '°' { $formula = new ConstValueFormula(MathHelper.DegreeToRadian(float.Parse($c.Text))); }
	|	CONST_ANGLE_DOWN { $formula = new ConstValueFormula(MathHelper.ANGLE_DOWN); }
	|	CONST_ANGLE_UP { $formula = new ConstValueFormula(MathHelper.ANGLE_UP); }
	|	CONST_ANGLE_LEFT { $formula = new ConstValueFormula(MathHelper.ANGLE_LEFT); }
	|	CONST_ANGLE_RIGHT { $formula = new ConstValueFormula(MathHelper.ANGLE_RIGHT); }
	|	PREDEF_ANGLE_TOWARD_PLAYER { $formula = new AngleTowardPlayerFormula(); }
	|	a=NUMBER '..' b=NUMBER { $formula = new RangeFormula(float.Parse(a.Text), float.Parse(b.Text)); }
	|	'(' f=formula ')' { $formula = $f.formula; }
	;
	
param returns [Param p]
	:	fp=fps_param        { $p = $fp.p; }
	|	gap=gamearea_param  { $p = $gap.p; }
	|	pp=position_param   { $p = $pp.p; }
	|	sp=speed_param      { $p = $sp.p; }
	|	ap=animation_param  { $p = $ap.p; }
	|	cp=color_param      { $p = $cp.p; }
	|	scp=scrolling_param { $p = $scp.p; }
	;

fps_param returns [Param p]
	:	PARAM_FPS '=' fps=NUMBER { $p = new FpsParam(float.Parse($fps.Text)); }
	;

gamearea_param returns [Param p]
	:	PARAM_GAMEAREA '=' area=RECTANGLE { $p = new GameAreaParam($area.Text); }
	;
	
position_param returns [Param p]
	:	PARAM_POSITION '=' pos=POINT { $p = new PositionParam($pos.Text); }
	;
	
speed_param returns [Param p]
	:	PARAM_SPEED '=' speed=NUMBER { $p = new SpeedParam(float.Parse($speed.Text)); }
	;
	
animation_param returns [Param p]
	:	PARAM_ANIMATION '=' anim=STRING { $p = new AnimationParam($anim.Text); }
	;
	
color_param returns [Param p]
	:	PARAM_COLOR '=' color=COLOR { $p = new ColorParam($color.Text); }
	;
	
scrolling_param returns [Param p]
	:	PARAM_SCROLLING '=' dir=DIRECTION ',' speed=NUMBER { $p = new ScrollingParam($dir.Text, float.Parse($speed.Text)); }
	;

classdef returns [Classdef en]
scope 
{ 
	List<Classdef> subEntities;
	List<Trigger> triggers;
}
@init 
{ 
	$classdef::subEntities = new List<Classdef>(); 
	$classdef::triggers = new List<Trigger>();
} 
	:	ee=engine_classdef { $en = $ee.en; $gbs::classdefs.Add($en); }
	|	pe=player_classdef { $en = $pe.en; $gbs::classdefs.Add($en); }
	|	be=bullet_classdef { $en = $be.en; $gbs::classdefs.Add($en); }
	|	ene=enemy_classdef { $en = $ene.en; $gbs::classdefs.Add($en); }
	|	eve=event_classdef { $en = $eve.en; $gbs::classdefs.Add($en); }
	|	ste=state_classdef { $en = $ste.en; $gbs::classdefs.Add($en); }
	|	se=script_classdef { $en = $se.en; $gbs::classdefs.Add($en); }
	;

classdef_content
	:	t=trigger        { $classdef::triggers.Add($t.t); }
	|	se=classdef        { $classdef::subEntities.Add($se.en); }
	;
	
engine_classdef returns [Classdef en]
	:	CLASSDEF_ENGINE '{' classdef_content* '}' { $en = new EngineClassdef($classdef::triggers); }
	;
	
player_classdef returns [Classdef en]
	:	CLASSDEF_PLAYER name=CLASS_IDENTIFIER '{' classdef_content* '}' { $en = new PlayerClassdef($name.Text, $classdef::subEntities, $classdef::triggers); }
	;

enemy_classdef returns [Classdef en]
	:	CLASSDEF_ENEMY name=CLASS_IDENTIFIER '{' classdef_content* '}' { $en = new EnemyClassdef($name.Text, $classdef::subEntities, $classdef::triggers); }
	;

bullet_classdef returns [Classdef en]
	:	CLASSDEF_BULLET name=CLASS_IDENTIFIER '{' classdef_content* '}' { $en = new BulletClassdef($name.Text, $classdef::subEntities, $classdef::triggers); }
	;
	
script_classdef returns [Classdef en]
	:	CLASSDEF_SCRIPT name=CLASS_IDENTIFIER '{' classdef_content* '}' { $en = new ScriptClassdef($name.Text, $classdef::subEntities, $classdef::triggers); }
	;

state_classdef returns [Classdef en]
	:	CLASSDEF_STATE name=CLASS_IDENTIFIER '{' classdef_content* '}' { $en = new StateClassdef($name.Text, $classdef::subEntities, $classdef::triggers); }
	;
		
event_classdef returns [Classdef en]
	:	CLASSDEF_EVENT name=CLASS_IDENTIFIER { $en = new EventClassdef($name.Text); }
	;

action_list returns [List<Action> actions]
scope 
{ 
	List<Action> list; 
}
@init 
{ 
	$action_list::list = new List<Action>(); 
} 
	:	action* { $actions = $action_list::list; }
	;

action_target returns [String target]
	:	THIS?                     { $target = "this"; }
	|	ident=INSTANCE_IDENTIFIER { $target = $ident.Text; }
	;

action
	:	pla=play_animation_action { $action_list::list.Add($pla.action); }
	|	pa=periodic_action        { $action_list::list.Add($pa.action); }
	|	fap=fire_action   { $action_list::list.Add($fap.action); }
	|	da=die_action             { $action_list::list.Add($da.action); }
	|	sta=start_action          { $action_list::list.Add($sta.action); }
	|	sa=stop_action            { $action_list::list.Add($sa.action); }
	|	sum=summon_action         { $action_list::list.Add($sum.action); }
	|	sea=set_action            { $action_list::list.Add($sea.action); }
	|	raa=raise_action	  { $action_list::list.Add($raa.action); }
	;
	
play_animation_action returns [Action action]
	:	target=action_target ACTION_PLAY_ANIMATION '(' anim=STRING ')' { $action = new PlayAnimationAction($target.target, $anim.Text); }
	;
	
periodic_action returns [Action action]
	:	target=action_target ACTION_PERIODIC '(' period=NUMBER ')' '{' actions=action_list '}' { $action = new PeriodicAction($target.target, $actions.actions, float.Parse($period.Text)); }
	;
	
fire_action returns [Action action]
	:	target=action_target ACTION_FIRE '(' bullet=CLASS_IDENTIFIER ',' angle=formula ')' { $action = new FireAction($target.target, $bullet.Text, $angle.formula); }
	;
	
die_action returns [Action action]
	:	target=action_target ACTION_DIE { $action = new DieAction($target.target); }
	;
	
start_action returns [Action action]
	:	target=action_target ACTION_START '(' st=CLASS_IDENTIFIER ')' { $action = new StartAction($target.target, $st.Text); }
	;

stop_action returns [Action action]
	:	target=action_target ACTION_STOP '(' st=CLASS_IDENTIFIER ')' { $action = new StopAction($target.target, $st.Text); }
	;
	
summon_action returns [Action action] // TODO prendre en compte les params de l'ennemi
	:	target=action_target ACTION_SUMMON '(' enemy=CLASS_IDENTIFIER ')' name=INSTANCE_IDENTIFIER ( '{' a=action_list '}' )? { $action = new SummonAction($target.target, $enemy.Text, $name.Text, $a.actions); }
	;
	
set_action returns [Action action]
	:	target=action_target ACTION_SET '(' p=param ')' { $action = new SetAction($target.target, $p.p); }
	|	p=param                                         { $action = new SetAction("this", $p.p); }
	;
	
raise_action returns [Action action]
	:	target=action_target ACTION_RAISE '(' e=CLASS_IDENTIFIER ')' { $action = new RaiseAction($target.target, $e.Text); }
	;
	
trigger returns [Trigger t]
	:	TRIGGER_INIT '{' a=action_list '}'                              { $t = new InitTrigger($a.actions); }
	|	TRIGGER_CLEANUP '{' a=action_list '}'                           { $t = new CleanupTrigger($a.actions); }
	|	TRIGGER_TIME '(' time=NUMBER ')' '{' a=action_list '}'          { $t = new TimeTrigger(float.Parse($time.Text), $a.actions); }
	|	TRIGGER_PERIODIC '(' period=NUMBER ')' '{' a=action_list '}'	{ $t = new PeriodicTrigger(float.Parse($period.Text), $a.actions); }
	|	TRIGGER_SCROLLING '(' scroll=NUMBER ')' '{' a=action_list '}'   { $t = new ScrollingTrigger(float.Parse($scroll.Text), $a.actions); }
	|	TRIGGER_ANIMATION_END '(' anim=STRING ')' '{' a=action_list '}' { $t = new AnimationEndTrigger($anim.Text, $a.actions); }
	|	TRIGGER_EVENT '(' e=CLASS_IDENTIFIER ')' '{' a=action_list '}'  { $t = new EventTrigger($e.Text, $a.actions); }
	;
	
