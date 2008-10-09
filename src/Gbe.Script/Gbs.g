grammar Gbs;

options 
{
	language=CSharp2;
	output=AST;
}

@parser::namespace 
{ 
	Gbe.Compiler 
}

@parser::header 
{
using System.Collections.Generic;
using Gbe.Compiler.Actions;
using Action = Gbe.Compiler.Actions.Action;
using Gbe.Compiler.Entities;
using Gbe.Compiler.Parameters;
using Gbe.Compiler.Triggers;
}

@lexer::namespace 
{ 
	Gbe.Compiler 
}

// LEXER

THIS
	:	'this'
	;

ENTITY_ENGINE	
	:	'ENGINE'
	;

ENTITY_PLAYER	
	:	'PLAYER'
	;

ENTITY_BULLET
	:	'BULLET'
	;

ENTITY_ENEMY	
	:	'ENEMY'
	;
	
ENTITY_SCRIPT
	:	'SCRIPT'
	;
	
ENTITY_STATE
	:	'STATE'
	;
	
ENTITY_EVENT
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
	
ACTION_FIRE_AT_PLAYER
	:	'.fireAtPlayer'
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
	
TRIGGER_INIT
	:	'@init'
	;
	
TRIGGER_CLEANUP
	:	'@cleanup'
	;
	
TRIGGER_TIME
	:	'@time'
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
	List<Entity> entities; 
}
@init 
{ 
	$gbs::entities = new List<Entity>(); 
} 
	:	entity* { $s = new Gbs($gbs::entities); }
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

entity returns [Entity en]
scope 
{ 
	List<Entity> subEntities;
	List<Trigger> triggers;
}
@init 
{ 
	$entity::subEntities = new List<Entity>(); 
	$entity::triggers = new List<Trigger>();
} 
	:	ee=engine_entity { $en = $ee.en; $gbs::entities.Add($en); }
	|	pe=player_entity { $en = $pe.en; $gbs::entities.Add($en); }
	|	be=bullet_entity { $en = $be.en; $gbs::entities.Add($en); }
	|	ene=enemy_entity { $en = $ene.en; $gbs::entities.Add($en); }
	|	eve=event_entity { $en = $eve.en; $gbs::entities.Add($en); }
	|	ste=state_entity { $en = $ste.en; $gbs::entities.Add($en); }
	|	se=script_entity { $en = $se.en; $gbs::entities.Add($en); }
	;

entity_content
	:	t=trigger        { $entity::triggers.Add($t.t); }
	|	se=entity        { $entity::subEntities.Add($se.en); }
	;
	
engine_entity returns [Entity en]
	:	ENTITY_ENGINE '{' entity_content* '}' { $en = new EngineEntity($entity::triggers); }
	;
	
player_entity returns [Entity en]
	:	ENTITY_PLAYER name=CLASS_IDENTIFIER '{' entity_content* '}' { $en = new PlayerEntity($name.Text, $entity::subEntities, $entity::triggers); }
	;

enemy_entity returns [Entity en]
	:	ENTITY_ENEMY name=CLASS_IDENTIFIER '{' entity_content* '}' { $en = new EnemyEntity($name.Text, $entity::subEntities, $entity::triggers); }
	;

bullet_entity returns [Entity en]
	:	ENTITY_BULLET name=CLASS_IDENTIFIER '{' entity_content* '}' { $en = new BulletEntity($name.Text, $entity::subEntities, $entity::triggers); }
	;
	
script_entity returns [Entity en]
	:	ENTITY_SCRIPT name=CLASS_IDENTIFIER '{' entity_content* '}' { $en = new ScriptEntity($name.Text, $entity::subEntities, $entity::triggers); }
	;

state_entity returns [Entity en]
	:	ENTITY_STATE name=CLASS_IDENTIFIER '{' entity_content* '}' { $en = new StateEntity($name.Text, $entity::subEntities, $entity::triggers); }
	;
		
event_entity returns [Entity en]
	:	ENTITY_EVENT name=CLASS_IDENTIFIER { $en = new EventEntity($name.Text); }
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
	|	fap=fireAtPlayer_action   { $action_list::list.Add($fap.action); }
	|	da=die_action             { $action_list::list.Add($da.action); }
	|	sta=start_action          { $action_list::list.Add($sta.action); }
	|	sa=stop_action            { $action_list::list.Add($sa.action); }
	|	sum=summon_action         { $action_list::list.Add($sum.action); }
	|	sea=set_action            { $action_list::list.Add($sea.action); }
	;
	
play_animation_action returns [Action action]
	:	target=action_target ACTION_PLAY_ANIMATION '(' anim=STRING ')' { $action = new PlayAnimationAction($target.target, $anim.Text); }
	;
	
periodic_action returns [Action action]
	:	target=action_target ACTION_PERIODIC '(' NUMBER ')' '{' actions=action_list '}' { $action = new PeriodicAction($target.target, $actions.actions); }
	;
	
fireAtPlayer_action returns [Action action]
	:	target=action_target ACTION_FIRE_AT_PLAYER '(' bullet=CLASS_IDENTIFIER ')' { $action = new FireAtPlayerAction($target.target, $bullet.Text); }
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
	
trigger returns [Trigger t]
	:	TRIGGER_INIT '{' a=action_list '}'                              { $t = new InitTrigger($a.actions); }
	|	TRIGGER_CLEANUP '{' a=action_list '}'                           { $t = new CleanupTrigger($a.actions); }
	|	TRIGGER_TIME '(' time=NUMBER ')' '{' a=action_list '}'          { $t = new TimeTrigger(float.Parse($time.Text), $a.actions); }
	|	TRIGGER_SCROLLING '(' scroll=NUMBER ')' '{' a=action_list '}'   { $t = new ScrollingTrigger(float.Parse($scroll.Text), $a.actions); }
	|	TRIGGER_ANIMATION_END '(' anim=STRING ')' '{' a=action_list '}' { $t = new AnimationEndTrigger($anim.Text, $a.actions); }
	|	TRIGGER_EVENT '(' e=CLASS_IDENTIFIER ')' '{' a=action_list '}'  { $t = new EventTrigger($e.Text, $a.actions); }
	;
	
