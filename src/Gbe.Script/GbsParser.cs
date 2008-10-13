// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-10-13 22:41:20
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  
	Gbe.Script 

{

using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Script.Actions;
using Action = Gbe.Script.Actions.Action;
using Gbe.Script.Classdefs;
using Gbe.Script.Formulas;
using Gbe.Script.Parameters;
using Gbe.Script.Triggers;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class GbsParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"THIS", 
		"CLASSDEF_ENGINE", 
		"CLASSDEF_PLAYER", 
		"CLASSDEF_BULLET", 
		"CLASSDEF_ENEMY", 
		"CLASSDEF_SCRIPT", 
		"CLASSDEF_STATE", 
		"CLASSDEF_EVENT", 
		"PARAM_FPS", 
		"PARAM_GAMEAREA", 
		"PARAM_POSITION", 
		"PARAM_COLOR", 
		"PARAM_SPEED", 
		"PARAM_ANIMATION", 
		"PARAM_SCROLLING", 
		"ACTION_PERIODIC", 
		"ACTION_FIRE", 
		"ACTION_DIE", 
		"ACTION_START", 
		"ACTION_STOP", 
		"ACTION_SUMMON", 
		"ACTION_PLAY_ANIMATION", 
		"ACTION_SET", 
		"ACTION_RAISE", 
		"TRIGGER_INIT", 
		"TRIGGER_CLEANUP", 
		"TRIGGER_TIME", 
		"TRIGGER_PERIODIC", 
		"TRIGGER_SCROLLING", 
		"TRIGGER_ANIMATION_END", 
		"TRIGGER_EVENT", 
		"PREDEF_ANGLE_TOWARD_PLAYER", 
		"CONST_ANGLE_DOWN", 
		"CONST_ANGLE_UP", 
		"CONST_ANGLE_LEFT", 
		"CONST_ANGLE_RIGHT", 
		"HEX_DIGIT", 
		"COLOR", 
		"CARDINAL_DIRECTION", 
		"NUMBER", 
		"DIRECTION", 
		"DIGIT", 
		"POINT", 
		"RECTANGLE", 
		"CLASS_IDENTIFIER", 
		"INSTANCE_IDENTIFIER", 
		"STRING", 
		"WHITESPACE", 
		"ML_COMMENT", 
		"SL_COMMENT", 
		"'='", 
		"','", 
		"'{'", 
		"'}'", 
		"'('", 
		"')'"
    };

    public const int DIRECTION = 44;
    public const int CONST_ANGLE_RIGHT = 39;
    public const int ACTION_SET = 26;
    public const int POINT = 46;
    public const int TRIGGER_SCROLLING = 32;
    public const int CLASSDEF_SCRIPT = 9;
    public const int CONST_ANGLE_UP = 37;
    public const int EOF = -1;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 41;
    public const int CLASSDEF_BULLET = 7;
    public const int TRIGGER_CLEANUP = 29;
    public const int T__55 = 55;
    public const int ML_COMMENT = 52;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int PARAM_ANIMATION = 17;
    public const int INSTANCE_IDENTIFIER = 49;
    public const int T__54 = 54;
    public const int TRIGGER_INIT = 28;
    public const int CONST_ANGLE_DOWN = 36;
    public const int T__59 = 59;
    public const int ACTION_START = 22;
    public const int THIS = 4;
    public const int RECTANGLE = 47;
    public const int CLASSDEF_PLAYER = 6;
    public const int PARAM_POSITION = 14;
    public const int DIGIT = 45;
    public const int CLASSDEF_EVENT = 11;
    public const int ACTION_PERIODIC = 19;
    public const int PARAM_GAMEAREA = 13;
    public const int PARAM_FPS = 12;
    public const int CLASSDEF_ENEMY = 8;
    public const int ACTION_SUMMON = 24;
    public const int NUMBER = 43;
    public const int WHITESPACE = 51;
    public const int HEX_DIGIT = 40;
    public const int TRIGGER_TIME = 30;
    public const int ACTION_STOP = 23;
    public const int TRIGGER_PERIODIC = 31;
    public const int TRIGGER_ANIMATION_END = 33;
    public const int ACTION_FIRE = 20;
    public const int TRIGGER_EVENT = 34;
    public const int CLASSDEF_STATE = 10;
    public const int CARDINAL_DIRECTION = 42;
    public const int PARAM_COLOR = 15;
    public const int PARAM_SPEED = 16;
    public const int CLASS_IDENTIFIER = 48;
    public const int CONST_ANGLE_LEFT = 38;
    public const int ACTION_RAISE = 27;
    public const int SL_COMMENT = 53;
    public const int PREDEF_ANGLE_TOWARD_PLAYER = 35;
    public const int ACTION_DIE = 21;
    public const int CLASSDEF_ENGINE = 5;
    public const int ACTION_PLAY_ANIMATION = 25;
    public const int STRING = 50;

    // delegates
    // delegators



        public GbsParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public GbsParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return GbsParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g"; }
    }


    public class formula_return : ParserRuleReturnScope
    {
        public Formula formula;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:246:1: formula returns [Formula formula] : (c= NUMBER | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER );
    public GbsParser.formula_return formula() // throws RecognitionException [1]
    {   
        GbsParser.formula_return retval = new GbsParser.formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken c = null;
        IToken CONST_ANGLE_DOWN1 = null;
        IToken CONST_ANGLE_UP2 = null;
        IToken CONST_ANGLE_LEFT3 = null;
        IToken CONST_ANGLE_RIGHT4 = null;
        IToken PREDEF_ANGLE_TOWARD_PLAYER5 = null;

        object c_tree=null;
        object CONST_ANGLE_DOWN1_tree=null;
        object CONST_ANGLE_UP2_tree=null;
        object CONST_ANGLE_LEFT3_tree=null;
        object CONST_ANGLE_RIGHT4_tree=null;
        object PREDEF_ANGLE_TOWARD_PLAYER5_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:247:2: (c= NUMBER | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case NUMBER:
            	{
                alt1 = 1;
                }
                break;
            case CONST_ANGLE_DOWN:
            	{
                alt1 = 2;
                }
                break;
            case CONST_ANGLE_UP:
            	{
                alt1 = 3;
                }
                break;
            case CONST_ANGLE_LEFT:
            	{
                alt1 = 4;
                }
                break;
            case CONST_ANGLE_RIGHT:
            	{
                alt1 = 5;
                }
                break;
            case PREDEF_ANGLE_TOWARD_PLAYER:
            	{
                alt1 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:247:4: c= NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_formula937); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	 retval.formula =  new ConstValueFormula(float.Parse(c.Text)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:248:4: CONST_ANGLE_DOWN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_DOWN1=(IToken)Match(input,CONST_ANGLE_DOWN,FOLLOW_CONST_ANGLE_DOWN_in_formula944); 
                    		CONST_ANGLE_DOWN1_tree = (object)adaptor.Create(CONST_ANGLE_DOWN1);
                    		adaptor.AddChild(root_0, CONST_ANGLE_DOWN1_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_DOWN); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:249:4: CONST_ANGLE_UP
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_UP2=(IToken)Match(input,CONST_ANGLE_UP,FOLLOW_CONST_ANGLE_UP_in_formula951); 
                    		CONST_ANGLE_UP2_tree = (object)adaptor.Create(CONST_ANGLE_UP2);
                    		adaptor.AddChild(root_0, CONST_ANGLE_UP2_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_UP); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:250:4: CONST_ANGLE_LEFT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_LEFT3=(IToken)Match(input,CONST_ANGLE_LEFT,FOLLOW_CONST_ANGLE_LEFT_in_formula958); 
                    		CONST_ANGLE_LEFT3_tree = (object)adaptor.Create(CONST_ANGLE_LEFT3);
                    		adaptor.AddChild(root_0, CONST_ANGLE_LEFT3_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_LEFT); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:251:4: CONST_ANGLE_RIGHT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_RIGHT4=(IToken)Match(input,CONST_ANGLE_RIGHT,FOLLOW_CONST_ANGLE_RIGHT_in_formula965); 
                    		CONST_ANGLE_RIGHT4_tree = (object)adaptor.Create(CONST_ANGLE_RIGHT4);
                    		adaptor.AddChild(root_0, CONST_ANGLE_RIGHT4_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_RIGHT); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:252:4: PREDEF_ANGLE_TOWARD_PLAYER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_TOWARD_PLAYER5=(IToken)Match(input,PREDEF_ANGLE_TOWARD_PLAYER,FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_formula972); 
                    		PREDEF_ANGLE_TOWARD_PLAYER5_tree = (object)adaptor.Create(PREDEF_ANGLE_TOWARD_PLAYER5);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_TOWARD_PLAYER5_tree);

                    	 retval.formula =  new AngleTowardPlayerFormula(); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formula"

    protected class gbs_scope 
    {
        protected internal List<Classdef> classdefs;
    }
    protected Stack gbs_stack = new Stack();

    public class gbs_return : ParserRuleReturnScope
    {
        public Gbs s;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "gbs"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:1: gbs returns [Gbs s] : ( classdef )* ;
    public GbsParser.gbs_return gbs() // throws RecognitionException [1]
    {   
        gbs_stack.Push(new gbs_scope());
        GbsParser.gbs_return retval = new GbsParser.gbs_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.classdef_return classdef6 = default(GbsParser.classdef_return);



         
        	((gbs_scope)gbs_stack.Peek()).classdefs =  new List<Classdef>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:264:2: ( ( classdef )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:264:4: ( classdef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:264:4: ( classdef )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= CLASSDEF_ENGINE && LA2_0 <= CLASSDEF_EVENT)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:264:4: classdef
            			    {
            			    	PushFollow(FOLLOW_classdef_in_gbs1001);
            			    	classdef6 = classdef();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef6.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	 retval.s =  new Gbs(((gbs_scope)gbs_stack.Peek()).classdefs); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            gbs_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "gbs"

    public class param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:267:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param );
    public GbsParser.param_return param() // throws RecognitionException [1]
    {   
        GbsParser.param_return retval = new GbsParser.param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.fps_param_return fp = default(GbsParser.fps_param_return);

        GbsParser.gamearea_param_return gap = default(GbsParser.gamearea_param_return);

        GbsParser.position_param_return pp = default(GbsParser.position_param_return);

        GbsParser.speed_param_return sp = default(GbsParser.speed_param_return);

        GbsParser.animation_param_return ap = default(GbsParser.animation_param_return);

        GbsParser.color_param_return cp = default(GbsParser.color_param_return);

        GbsParser.scrolling_param_return scp = default(GbsParser.scrolling_param_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:268:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param )
            int alt3 = 7;
            switch ( input.LA(1) ) 
            {
            case PARAM_FPS:
            	{
                alt3 = 1;
                }
                break;
            case PARAM_GAMEAREA:
            	{
                alt3 = 2;
                }
                break;
            case PARAM_POSITION:
            	{
                alt3 = 3;
                }
                break;
            case PARAM_SPEED:
            	{
                alt3 = 4;
                }
                break;
            case PARAM_ANIMATION:
            	{
                alt3 = 5;
                }
                break;
            case PARAM_COLOR:
            	{
                alt3 = 6;
                }
                break;
            case PARAM_SCROLLING:
            	{
                alt3 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:268:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param1021);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param1037);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:270:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param1047);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:271:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param1058);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:272:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param1072);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:273:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param1082);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:274:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param1096);
                    	scp = scrolling_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, scp.Tree);
                    	 retval.p =  ((scp != null) ? scp.p : default(Param)); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "param"

    public class fps_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fps_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
    public GbsParser.fps_param_return fps_param() // throws RecognitionException [1]
    {   
        GbsParser.fps_param_return retval = new GbsParser.fps_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken fps = null;
        IToken PARAM_FPS7 = null;
        IToken char_literal8 = null;

        object fps_tree=null;
        object PARAM_FPS7_tree=null;
        object char_literal8_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:278:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:278:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS7=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param1113); 
            		PARAM_FPS7_tree = (object)adaptor.Create(PARAM_FPS7);
            		adaptor.AddChild(root_0, PARAM_FPS7_tree);

            	char_literal8=(IToken)Match(input,54,FOLLOW_54_in_fps_param1115); 
            		char_literal8_tree = (object)adaptor.Create(char_literal8);
            		adaptor.AddChild(root_0, char_literal8_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param1119); 
            		fps_tree = (object)adaptor.Create(fps);
            		adaptor.AddChild(root_0, fps_tree);

            	 retval.p =  new FpsParam(float.Parse(fps.Text)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fps_param"

    public class gamearea_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "gamearea_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:281:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
    public GbsParser.gamearea_param_return gamearea_param() // throws RecognitionException [1]
    {   
        GbsParser.gamearea_param_return retval = new GbsParser.gamearea_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken area = null;
        IToken PARAM_GAMEAREA9 = null;
        IToken char_literal10 = null;

        object area_tree=null;
        object PARAM_GAMEAREA9_tree=null;
        object char_literal10_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:282:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:282:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA9=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1136); 
            		PARAM_GAMEAREA9_tree = (object)adaptor.Create(PARAM_GAMEAREA9);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA9_tree);

            	char_literal10=(IToken)Match(input,54,FOLLOW_54_in_gamearea_param1138); 
            		char_literal10_tree = (object)adaptor.Create(char_literal10);
            		adaptor.AddChild(root_0, char_literal10_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1142); 
            		area_tree = (object)adaptor.Create(area);
            		adaptor.AddChild(root_0, area_tree);

            	 retval.p =  new GameAreaParam(area.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "gamearea_param"

    public class position_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "position_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:285:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
    public GbsParser.position_param_return position_param() // throws RecognitionException [1]
    {   
        GbsParser.position_param_return retval = new GbsParser.position_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken pos = null;
        IToken PARAM_POSITION11 = null;
        IToken char_literal12 = null;

        object pos_tree=null;
        object PARAM_POSITION11_tree=null;
        object char_literal12_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:286:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:286:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION11=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1160); 
            		PARAM_POSITION11_tree = (object)adaptor.Create(PARAM_POSITION11);
            		adaptor.AddChild(root_0, PARAM_POSITION11_tree);

            	char_literal12=(IToken)Match(input,54,FOLLOW_54_in_position_param1162); 
            		char_literal12_tree = (object)adaptor.Create(char_literal12);
            		adaptor.AddChild(root_0, char_literal12_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1166); 
            		pos_tree = (object)adaptor.Create(pos);
            		adaptor.AddChild(root_0, pos_tree);

            	 retval.p =  new PositionParam(pos.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "position_param"

    public class speed_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "speed_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:289:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
    public GbsParser.speed_param_return speed_param() // throws RecognitionException [1]
    {   
        GbsParser.speed_param_return retval = new GbsParser.speed_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken speed = null;
        IToken PARAM_SPEED13 = null;
        IToken char_literal14 = null;

        object speed_tree=null;
        object PARAM_SPEED13_tree=null;
        object char_literal14_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:290:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:290:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED13=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1184); 
            		PARAM_SPEED13_tree = (object)adaptor.Create(PARAM_SPEED13);
            		adaptor.AddChild(root_0, PARAM_SPEED13_tree);

            	char_literal14=(IToken)Match(input,54,FOLLOW_54_in_speed_param1186); 
            		char_literal14_tree = (object)adaptor.Create(char_literal14);
            		adaptor.AddChild(root_0, char_literal14_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1190); 
            		speed_tree = (object)adaptor.Create(speed);
            		adaptor.AddChild(root_0, speed_tree);

            	 retval.p =  new SpeedParam(float.Parse(speed.Text)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "speed_param"

    public class animation_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "animation_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:293:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
    public GbsParser.animation_param_return animation_param() // throws RecognitionException [1]
    {   
        GbsParser.animation_param_return retval = new GbsParser.animation_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken PARAM_ANIMATION15 = null;
        IToken char_literal16 = null;

        object anim_tree=null;
        object PARAM_ANIMATION15_tree=null;
        object char_literal16_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:294:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:294:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION15=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1208); 
            		PARAM_ANIMATION15_tree = (object)adaptor.Create(PARAM_ANIMATION15);
            		adaptor.AddChild(root_0, PARAM_ANIMATION15_tree);

            	char_literal16=(IToken)Match(input,54,FOLLOW_54_in_animation_param1210); 
            		char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1214); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	 retval.p =  new AnimationParam(anim.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "animation_param"

    public class color_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "color_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:297:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
    public GbsParser.color_param_return color_param() // throws RecognitionException [1]
    {   
        GbsParser.color_param_return retval = new GbsParser.color_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken color = null;
        IToken PARAM_COLOR17 = null;
        IToken char_literal18 = null;

        object color_tree=null;
        object PARAM_COLOR17_tree=null;
        object char_literal18_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR17=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1232); 
            		PARAM_COLOR17_tree = (object)adaptor.Create(PARAM_COLOR17);
            		adaptor.AddChild(root_0, PARAM_COLOR17_tree);

            	char_literal18=(IToken)Match(input,54,FOLLOW_54_in_color_param1234); 
            		char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1238); 
            		color_tree = (object)adaptor.Create(color);
            		adaptor.AddChild(root_0, color_tree);

            	 retval.p =  new ColorParam(color.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "color_param"

    public class scrolling_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scrolling_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:301:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
    public GbsParser.scrolling_param_return scrolling_param() // throws RecognitionException [1]
    {   
        GbsParser.scrolling_param_return retval = new GbsParser.scrolling_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken dir = null;
        IToken speed = null;
        IToken PARAM_SCROLLING19 = null;
        IToken char_literal20 = null;
        IToken char_literal21 = null;

        object dir_tree=null;
        object speed_tree=null;
        object PARAM_SCROLLING19_tree=null;
        object char_literal20_tree=null;
        object char_literal21_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:302:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:302:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING19=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1256); 
            		PARAM_SCROLLING19_tree = (object)adaptor.Create(PARAM_SCROLLING19);
            		adaptor.AddChild(root_0, PARAM_SCROLLING19_tree);

            	char_literal20=(IToken)Match(input,54,FOLLOW_54_in_scrolling_param1258); 
            		char_literal20_tree = (object)adaptor.Create(char_literal20);
            		adaptor.AddChild(root_0, char_literal20_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1262); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal21=(IToken)Match(input,55,FOLLOW_55_in_scrolling_param1264); 
            		char_literal21_tree = (object)adaptor.Create(char_literal21);
            		adaptor.AddChild(root_0, char_literal21_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1268); 
            		speed_tree = (object)adaptor.Create(speed);
            		adaptor.AddChild(root_0, speed_tree);

            	 retval.p =  new ScrollingParam(dir.Text, float.Parse(speed.Text)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scrolling_param"

    protected class classdef_scope 
    {
        protected internal List<Classdef> subEntities;
        protected internal List<Trigger> triggers;
    }
    protected Stack classdef_stack = new Stack();

    public class classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:305:1: classdef returns [Classdef en] : (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef );
    public GbsParser.classdef_return classdef() // throws RecognitionException [1]
    {   
        classdef_stack.Push(new classdef_scope());
        GbsParser.classdef_return retval = new GbsParser.classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.engine_classdef_return ee = default(GbsParser.engine_classdef_return);

        GbsParser.player_classdef_return pe = default(GbsParser.player_classdef_return);

        GbsParser.bullet_classdef_return be = default(GbsParser.bullet_classdef_return);

        GbsParser.enemy_classdef_return ene = default(GbsParser.enemy_classdef_return);

        GbsParser.event_classdef_return eve = default(GbsParser.event_classdef_return);

        GbsParser.state_classdef_return ste = default(GbsParser.state_classdef_return);

        GbsParser.script_classdef_return se = default(GbsParser.script_classdef_return);



         
        	((classdef_scope)classdef_stack.Peek()).subEntities =  new List<Classdef>(); 
        	((classdef_scope)classdef_stack.Peek()).triggers =  new List<Trigger>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:2: (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef )
            int alt4 = 7;
            switch ( input.LA(1) ) 
            {
            case CLASSDEF_ENGINE:
            	{
                alt4 = 1;
                }
                break;
            case CLASSDEF_PLAYER:
            	{
                alt4 = 2;
                }
                break;
            case CLASSDEF_BULLET:
            	{
                alt4 = 3;
                }
                break;
            case CLASSDEF_ENEMY:
            	{
                alt4 = 4;
                }
                break;
            case CLASSDEF_EVENT:
            	{
                alt4 = 5;
                }
                break;
            case CLASSDEF_STATE:
            	{
                alt4 = 6;
                }
                break;
            case CLASSDEF_SCRIPT:
            	{
                alt4 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:4: ee= engine_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_classdef_in_classdef1299);
                    	ee = engine_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:317:4: pe= player_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_classdef_in_classdef1308);
                    	pe = player_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:318:4: be= bullet_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_classdef_in_classdef1317);
                    	be = bullet_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:319:4: ene= enemy_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_classdef_in_classdef1326);
                    	ene = enemy_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:4: eve= event_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_classdef_in_classdef1335);
                    	eve = event_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:321:4: ste= state_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_classdef_in_classdef1344);
                    	ste = state_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:322:4: se= script_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_classdef_in_classdef1353);
                    	se = script_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, se.Tree);
                    	 retval.en =  ((se != null) ? se.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            classdef_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "classdef"

    public class classdef_content_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "classdef_content"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:325:1: classdef_content : (t= trigger | se= classdef );
    public GbsParser.classdef_content_return classdef_content() // throws RecognitionException [1]
    {   
        GbsParser.classdef_content_return retval = new GbsParser.classdef_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.classdef_return se = default(GbsParser.classdef_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:326:2: (t= trigger | se= classdef )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0 >= TRIGGER_INIT && LA5_0 <= TRIGGER_EVENT)) )
            {
                alt5 = 1;
            }
            else if ( ((LA5_0 >= CLASSDEF_ENGINE && LA5_0 <= CLASSDEF_EVENT)) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:326:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_classdef_content1368);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:327:4: se= classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classdef_in_classdef_content1384);
                    	se = classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, se.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).subEntities.Add(((se != null) ? se.en : default(Classdef))); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "classdef_content"

    public class engine_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "engine_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:330:1: engine_classdef returns [Classdef en] : CLASSDEF_ENGINE '{' ( classdef_content )* '}' ;
    public GbsParser.engine_classdef_return engine_classdef() // throws RecognitionException [1]
    {   
        GbsParser.engine_classdef_return retval = new GbsParser.engine_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASSDEF_ENGINE22 = null;
        IToken char_literal23 = null;
        IToken char_literal25 = null;
        GbsParser.classdef_content_return classdef_content24 = default(GbsParser.classdef_content_return);


        object CLASSDEF_ENGINE22_tree=null;
        object char_literal23_tree=null;
        object char_literal25_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:331:2: ( CLASSDEF_ENGINE '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:331:4: CLASSDEF_ENGINE '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENGINE22=(IToken)Match(input,CLASSDEF_ENGINE,FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1409); 
            		CLASSDEF_ENGINE22_tree = (object)adaptor.Create(CLASSDEF_ENGINE22);
            		adaptor.AddChild(root_0, CLASSDEF_ENGINE22_tree);

            	char_literal23=(IToken)Match(input,56,FOLLOW_56_in_engine_classdef1411); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:331:24: ( classdef_content )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= CLASSDEF_ENGINE && LA6_0 <= CLASSDEF_EVENT) || (LA6_0 >= TRIGGER_INIT && LA6_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:331:24: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_engine_classdef1413);
            			    	classdef_content24 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content24.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal25=(IToken)Match(input,57,FOLLOW_57_in_engine_classdef1416); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	 retval.en =  new EngineClassdef(((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "engine_classdef"

    public class player_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "player_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:334:1: player_classdef returns [Classdef en] : CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.player_classdef_return player_classdef() // throws RecognitionException [1]
    {   
        GbsParser.player_classdef_return retval = new GbsParser.player_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_PLAYER26 = null;
        IToken char_literal27 = null;
        IToken char_literal29 = null;
        GbsParser.classdef_content_return classdef_content28 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_PLAYER26_tree=null;
        object char_literal27_tree=null;
        object char_literal29_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:335:2: ( CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:335:4: CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_PLAYER26=(IToken)Match(input,CLASSDEF_PLAYER,FOLLOW_CLASSDEF_PLAYER_in_player_classdef1434); 
            		CLASSDEF_PLAYER26_tree = (object)adaptor.Create(CLASSDEF_PLAYER26);
            		adaptor.AddChild(root_0, CLASSDEF_PLAYER26_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_classdef1438); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal27=(IToken)Match(input,56,FOLLOW_56_in_player_classdef1440); 
            		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:335:46: ( classdef_content )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= CLASSDEF_ENGINE && LA7_0 <= CLASSDEF_EVENT) || (LA7_0 >= TRIGGER_INIT && LA7_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:335:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_player_classdef1442);
            			    	classdef_content28 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content28.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal29=(IToken)Match(input,57,FOLLOW_57_in_player_classdef1445); 
            		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		adaptor.AddChild(root_0, char_literal29_tree);

            	 retval.en =  new PlayerClassdef(name.Text, ((classdef_scope)classdef_stack.Peek()).subEntities, ((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "player_classdef"

    public class enemy_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "enemy_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:338:1: enemy_classdef returns [Classdef en] : CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.enemy_classdef_return enemy_classdef() // throws RecognitionException [1]
    {   
        GbsParser.enemy_classdef_return retval = new GbsParser.enemy_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_ENEMY30 = null;
        IToken char_literal31 = null;
        IToken char_literal33 = null;
        GbsParser.classdef_content_return classdef_content32 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_ENEMY30_tree=null;
        object char_literal31_tree=null;
        object char_literal33_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:2: ( CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:4: CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENEMY30=(IToken)Match(input,CLASSDEF_ENEMY,FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1462); 
            		CLASSDEF_ENEMY30_tree = (object)adaptor.Create(CLASSDEF_ENEMY30);
            		adaptor.AddChild(root_0, CLASSDEF_ENEMY30_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1466); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal31=(IToken)Match(input,56,FOLLOW_56_in_enemy_classdef1468); 
            		char_literal31_tree = (object)adaptor.Create(char_literal31);
            		adaptor.AddChild(root_0, char_literal31_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:45: ( classdef_content )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= CLASSDEF_ENGINE && LA8_0 <= CLASSDEF_EVENT) || (LA8_0 >= TRIGGER_INIT && LA8_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_enemy_classdef1470);
            			    	classdef_content32 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content32.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal33=(IToken)Match(input,57,FOLLOW_57_in_enemy_classdef1473); 
            		char_literal33_tree = (object)adaptor.Create(char_literal33);
            		adaptor.AddChild(root_0, char_literal33_tree);

            	 retval.en =  new EnemyClassdef(name.Text, ((classdef_scope)classdef_stack.Peek()).subEntities, ((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enemy_classdef"

    public class bullet_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bullet_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:342:1: bullet_classdef returns [Classdef en] : CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.bullet_classdef_return bullet_classdef() // throws RecognitionException [1]
    {   
        GbsParser.bullet_classdef_return retval = new GbsParser.bullet_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_BULLET34 = null;
        IToken char_literal35 = null;
        IToken char_literal37 = null;
        GbsParser.classdef_content_return classdef_content36 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_BULLET34_tree=null;
        object char_literal35_tree=null;
        object char_literal37_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:343:2: ( CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:343:4: CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_BULLET34=(IToken)Match(input,CLASSDEF_BULLET,FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1490); 
            		CLASSDEF_BULLET34_tree = (object)adaptor.Create(CLASSDEF_BULLET34);
            		adaptor.AddChild(root_0, CLASSDEF_BULLET34_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1494); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal35=(IToken)Match(input,56,FOLLOW_56_in_bullet_classdef1496); 
            		char_literal35_tree = (object)adaptor.Create(char_literal35);
            		adaptor.AddChild(root_0, char_literal35_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:343:46: ( classdef_content )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= CLASSDEF_ENGINE && LA9_0 <= CLASSDEF_EVENT) || (LA9_0 >= TRIGGER_INIT && LA9_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:343:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_bullet_classdef1498);
            			    	classdef_content36 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	char_literal37=(IToken)Match(input,57,FOLLOW_57_in_bullet_classdef1501); 
            		char_literal37_tree = (object)adaptor.Create(char_literal37);
            		adaptor.AddChild(root_0, char_literal37_tree);

            	 retval.en =  new BulletClassdef(name.Text, ((classdef_scope)classdef_stack.Peek()).subEntities, ((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bullet_classdef"

    public class script_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "script_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:346:1: script_classdef returns [Classdef en] : CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.script_classdef_return script_classdef() // throws RecognitionException [1]
    {   
        GbsParser.script_classdef_return retval = new GbsParser.script_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_SCRIPT38 = null;
        IToken char_literal39 = null;
        IToken char_literal41 = null;
        GbsParser.classdef_content_return classdef_content40 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_SCRIPT38_tree=null;
        object char_literal39_tree=null;
        object char_literal41_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:2: ( CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:4: CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_SCRIPT38=(IToken)Match(input,CLASSDEF_SCRIPT,FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1519); 
            		CLASSDEF_SCRIPT38_tree = (object)adaptor.Create(CLASSDEF_SCRIPT38);
            		adaptor.AddChild(root_0, CLASSDEF_SCRIPT38_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_classdef1523); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal39=(IToken)Match(input,56,FOLLOW_56_in_script_classdef1525); 
            		char_literal39_tree = (object)adaptor.Create(char_literal39);
            		adaptor.AddChild(root_0, char_literal39_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:46: ( classdef_content )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= CLASSDEF_ENGINE && LA10_0 <= CLASSDEF_EVENT) || (LA10_0 >= TRIGGER_INIT && LA10_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_script_classdef1527);
            			    	classdef_content40 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal41=(IToken)Match(input,57,FOLLOW_57_in_script_classdef1530); 
            		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		adaptor.AddChild(root_0, char_literal41_tree);

            	 retval.en =  new ScriptClassdef(name.Text, ((classdef_scope)classdef_stack.Peek()).subEntities, ((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "script_classdef"

    public class state_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "state_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:350:1: state_classdef returns [Classdef en] : CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.state_classdef_return state_classdef() // throws RecognitionException [1]
    {   
        GbsParser.state_classdef_return retval = new GbsParser.state_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_STATE42 = null;
        IToken char_literal43 = null;
        IToken char_literal45 = null;
        GbsParser.classdef_content_return classdef_content44 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_STATE42_tree=null;
        object char_literal43_tree=null;
        object char_literal45_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:2: ( CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:4: CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_STATE42=(IToken)Match(input,CLASSDEF_STATE,FOLLOW_CLASSDEF_STATE_in_state_classdef1547); 
            		CLASSDEF_STATE42_tree = (object)adaptor.Create(CLASSDEF_STATE42);
            		adaptor.AddChild(root_0, CLASSDEF_STATE42_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_classdef1551); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal43=(IToken)Match(input,56,FOLLOW_56_in_state_classdef1553); 
            		char_literal43_tree = (object)adaptor.Create(char_literal43);
            		adaptor.AddChild(root_0, char_literal43_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:45: ( classdef_content )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= CLASSDEF_ENGINE && LA11_0 <= CLASSDEF_EVENT) || (LA11_0 >= TRIGGER_INIT && LA11_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_state_classdef1555);
            			    	classdef_content44 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content44.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal45=(IToken)Match(input,57,FOLLOW_57_in_state_classdef1558); 
            		char_literal45_tree = (object)adaptor.Create(char_literal45);
            		adaptor.AddChild(root_0, char_literal45_tree);

            	 retval.en =  new StateClassdef(name.Text, ((classdef_scope)classdef_stack.Peek()).subEntities, ((classdef_scope)classdef_stack.Peek()).triggers); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "state_classdef"

    public class event_classdef_return : ParserRuleReturnScope
    {
        public Classdef en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "event_classdef"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:354:1: event_classdef returns [Classdef en] : CLASSDEF_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_classdef_return event_classdef() // throws RecognitionException [1]
    {   
        GbsParser.event_classdef_return retval = new GbsParser.event_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_EVENT46 = null;

        object name_tree=null;
        object CLASSDEF_EVENT46_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:355:2: ( CLASSDEF_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:355:4: CLASSDEF_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_EVENT46=(IToken)Match(input,CLASSDEF_EVENT,FOLLOW_CLASSDEF_EVENT_in_event_classdef1577); 
            		CLASSDEF_EVENT46_tree = (object)adaptor.Create(CLASSDEF_EVENT46);
            		adaptor.AddChild(root_0, CLASSDEF_EVENT46_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_classdef1581); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	 retval.en =  new EventClassdef(name.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "event_classdef"

    protected class action_list_scope 
    {
        protected internal List<Action> list;
    }
    protected Stack action_list_stack = new Stack();

    public class action_list_return : ParserRuleReturnScope
    {
        public List<Action> actions;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "action_list"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:358:1: action_list returns [List<Action> actions] : ( action )* ;
    public GbsParser.action_list_return action_list() // throws RecognitionException [1]
    {   
        action_list_stack.Push(new action_list_scope());
        GbsParser.action_list_return retval = new GbsParser.action_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.action_return action47 = default(GbsParser.action_return);



         
        	((action_list_scope)action_list_stack.Peek()).list =  new List<Action>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:367:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:367:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:367:4: ( action )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == THIS || (LA12_0 >= PARAM_FPS && LA12_0 <= ACTION_RAISE) || LA12_0 == INSTANCE_IDENTIFIER) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:367:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1610);
            			    	action47 = action();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, action47.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	 retval.actions =  ((action_list_scope)action_list_stack.Peek()).list; 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            action_list_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "action_list"

    public class action_target_return : ParserRuleReturnScope
    {
        public String target;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "action_target"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:370:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
    public GbsParser.action_target_return action_target() // throws RecognitionException [1]
    {   
        GbsParser.action_target_return retval = new GbsParser.action_target_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ident = null;
        IToken THIS48 = null;

        object ident_tree=null;
        object THIS48_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:371:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == THIS || (LA14_0 >= ACTION_PERIODIC && LA14_0 <= ACTION_RAISE)) )
            {
                alt14 = 1;
            }
            else if ( (LA14_0 == INSTANCE_IDENTIFIER) )
            {
                alt14 = 2;
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:371:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:371:4: ( THIS )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == THIS) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:371:4: THIS
                    	        {
                    	        	THIS48=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target1628); 
                    	        		THIS48_tree = (object)adaptor.Create(THIS48);
                    	        		adaptor.AddChild(root_0, THIS48_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target1658); 
                    		ident_tree = (object)adaptor.Create(ident);
                    		adaptor.AddChild(root_0, ident_tree);

                    	 retval.target =  ident.Text; 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "action_target"

    public class action_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:375:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );
    public GbsParser.action_return action() // throws RecognitionException [1]
    {   
        GbsParser.action_return retval = new GbsParser.action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.play_animation_action_return pla = default(GbsParser.play_animation_action_return);

        GbsParser.periodic_action_return pa = default(GbsParser.periodic_action_return);

        GbsParser.fire_action_return fap = default(GbsParser.fire_action_return);

        GbsParser.die_action_return da = default(GbsParser.die_action_return);

        GbsParser.start_action_return sta = default(GbsParser.start_action_return);

        GbsParser.stop_action_return sa = default(GbsParser.stop_action_return);

        GbsParser.summon_action_return sum = default(GbsParser.summon_action_return);

        GbsParser.set_action_return sea = default(GbsParser.set_action_return);

        GbsParser.raise_action_return raa = default(GbsParser.raise_action_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:2: (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action )
            int alt15 = 9;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action1673);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action1682);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:378:4: fap= fire_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_action_in_action1698);
                    	fap = fire_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:379:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action1709);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:380:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action1730);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action1748);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:382:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action1768);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:383:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action1785);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:384:4: raa= raise_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_raise_action_in_action1805);
                    	raa = raise_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, raa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((raa != null) ? raa.action : default(Action))); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "action"

    public class play_animation_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "play_animation_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:387:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
    public GbsParser.play_animation_action_return play_animation_action() // throws RecognitionException [1]
    {   
        GbsParser.play_animation_action_return retval = new GbsParser.play_animation_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken ACTION_PLAY_ANIMATION49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object anim_tree=null;
        object ACTION_PLAY_ANIMATION49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action1827);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION49=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1829); 
            		ACTION_PLAY_ANIMATION49_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION49);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION49_tree);

            	char_literal50=(IToken)Match(input,58,FOLLOW_58_in_play_animation_action1831); 
            		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		adaptor.AddChild(root_0, char_literal50_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action1835); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal51=(IToken)Match(input,59,FOLLOW_59_in_play_animation_action1837); 
            		char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);

            	 retval.action =  new PlayAnimationAction(((target != null) ? target.target : default(String)), anim.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "play_animation_action"

    public class periodic_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "periodic_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:391:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken period = null;
        IToken ACTION_PERIODIC52 = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        IToken char_literal55 = null;
        IToken char_literal56 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object period_tree=null;
        object ACTION_PERIODIC52_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;
        object char_literal55_tree=null;
        object char_literal56_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:2: (target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:4: target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action1857);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC52=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action1859); 
            		ACTION_PERIODIC52_tree = (object)adaptor.Create(ACTION_PERIODIC52);
            		adaptor.AddChild(root_0, ACTION_PERIODIC52_tree);

            	char_literal53=(IToken)Match(input,58,FOLLOW_58_in_periodic_action1861); 
            		char_literal53_tree = (object)adaptor.Create(char_literal53);
            		adaptor.AddChild(root_0, char_literal53_tree);

            	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action1865); 
            		period_tree = (object)adaptor.Create(period);
            		adaptor.AddChild(root_0, period_tree);

            	char_literal54=(IToken)Match(input,59,FOLLOW_59_in_periodic_action1867); 
            		char_literal54_tree = (object)adaptor.Create(char_literal54);
            		adaptor.AddChild(root_0, char_literal54_tree);

            	char_literal55=(IToken)Match(input,56,FOLLOW_56_in_periodic_action1869); 
            		char_literal55_tree = (object)adaptor.Create(char_literal55);
            		adaptor.AddChild(root_0, char_literal55_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action1873);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal56=(IToken)Match(input,57,FOLLOW_57_in_periodic_action1875); 
            		char_literal56_tree = (object)adaptor.Create(char_literal56);
            		adaptor.AddChild(root_0, char_literal56_tree);

            	 retval.action =  new PeriodicAction(((target != null) ? target.target : default(String)), ((actions != null) ? actions.actions : default(List<Action>)), float.Parse(period.Text)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "periodic_action"

    public class fire_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fire_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:395:1: fire_action returns [Action action] : target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' ;
    public GbsParser.fire_action_return fire_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_action_return retval = new GbsParser.fire_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE57 = null;
        IToken char_literal58 = null;
        IToken char_literal59 = null;
        IToken char_literal60 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return angle = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE57_tree=null;
        object char_literal58_tree=null;
        object char_literal59_tree=null;
        object char_literal60_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:396:2: (target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:396:4: target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_action1895);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE57=(IToken)Match(input,ACTION_FIRE,FOLLOW_ACTION_FIRE_in_fire_action1897); 
            		ACTION_FIRE57_tree = (object)adaptor.Create(ACTION_FIRE57);
            		adaptor.AddChild(root_0, ACTION_FIRE57_tree);

            	char_literal58=(IToken)Match(input,58,FOLLOW_58_in_fire_action1899); 
            		char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_action1903); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal59=(IToken)Match(input,55,FOLLOW_55_in_fire_action1905); 
            		char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);

            	PushFollow(FOLLOW_formula_in_fire_action1909);
            	angle = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, angle.Tree);
            	char_literal60=(IToken)Match(input,59,FOLLOW_59_in_fire_action1911); 
            		char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);

            	 retval.action =  new FireAction(((target != null) ? target.target : default(String)), bullet.Text, ((angle != null) ? angle.formula : default(Formula))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fire_action"

    public class die_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "die_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:399:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE61 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE61_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:400:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:400:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action1931);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE61=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action1933); 
            		ACTION_DIE61_tree = (object)adaptor.Create(ACTION_DIE61);
            		adaptor.AddChild(root_0, ACTION_DIE61_tree);

            	 retval.action =  new DieAction(((target != null) ? target.target : default(String))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "die_action"

    public class start_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "start_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:403:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START62_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:404:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:404:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action1953);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START62=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action1955); 
            		ACTION_START62_tree = (object)adaptor.Create(ACTION_START62);
            		adaptor.AddChild(root_0, ACTION_START62_tree);

            	char_literal63=(IToken)Match(input,58,FOLLOW_58_in_start_action1957); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action1961); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal64=(IToken)Match(input,59,FOLLOW_59_in_start_action1963); 
            		char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);

            	 retval.action =  new StartAction(((target != null) ? target.target : default(String)), st.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "start_action"

    public class stop_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "stop_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:407:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP65 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP65_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:408:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:408:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action1982);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP65=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action1984); 
            		ACTION_STOP65_tree = (object)adaptor.Create(ACTION_STOP65);
            		adaptor.AddChild(root_0, ACTION_STOP65_tree);

            	char_literal66=(IToken)Match(input,58,FOLLOW_58_in_stop_action1986); 
            		char_literal66_tree = (object)adaptor.Create(char_literal66);
            		adaptor.AddChild(root_0, char_literal66_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action1990); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal67=(IToken)Match(input,59,FOLLOW_59_in_stop_action1992); 
            		char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);

            	 retval.action =  new StopAction(((target != null) ? target.target : default(String)), st.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stop_action"

    public class summon_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "summon_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:411:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON68 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON68_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:412:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:412:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action2013);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON68=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action2015); 
            		ACTION_SUMMON68_tree = (object)adaptor.Create(ACTION_SUMMON68);
            		adaptor.AddChild(root_0, ACTION_SUMMON68_tree);

            	char_literal69=(IToken)Match(input,58,FOLLOW_58_in_summon_action2017); 
            		char_literal69_tree = (object)adaptor.Create(char_literal69);
            		adaptor.AddChild(root_0, char_literal69_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action2021); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal70=(IToken)Match(input,59,FOLLOW_59_in_summon_action2023); 
            		char_literal70_tree = (object)adaptor.Create(char_literal70);
            		adaptor.AddChild(root_0, char_literal70_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2027); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:412:95: ( '{' a= action_list '}' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 56) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:412:97: '{' a= action_list '}'
            	        {
            	        	char_literal71=(IToken)Match(input,56,FOLLOW_56_in_summon_action2031); 
            	        		char_literal71_tree = (object)adaptor.Create(char_literal71);
            	        		adaptor.AddChild(root_0, char_literal71_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action2035);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal72=(IToken)Match(input,57,FOLLOW_57_in_summon_action2037); 
            	        		char_literal72_tree = (object)adaptor.Create(char_literal72);
            	        		adaptor.AddChild(root_0, char_literal72_tree);


            	        }
            	        break;

            	}

            	 retval.action =  new SummonAction(((target != null) ? target.target : default(String)), enemy.Text, name.Text, ((a != null) ? a.actions : default(List<Action>))); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "summon_action"

    public class set_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "set_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:415:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET73 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET73_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:416:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == THIS || (LA17_0 >= ACTION_PERIODIC && LA17_0 <= ACTION_RAISE) || LA17_0 == INSTANCE_IDENTIFIER) )
            {
                alt17 = 1;
            }
            else if ( ((LA17_0 >= PARAM_FPS && LA17_0 <= PARAM_SCROLLING)) )
            {
                alt17 = 2;
            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:416:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action2060);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET73=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action2062); 
                    		ACTION_SET73_tree = (object)adaptor.Create(ACTION_SET73);
                    		adaptor.AddChild(root_0, ACTION_SET73_tree);

                    	char_literal74=(IToken)Match(input,58,FOLLOW_58_in_set_action2064); 
                    		char_literal74_tree = (object)adaptor.Create(char_literal74);
                    		adaptor.AddChild(root_0, char_literal74_tree);

                    	PushFollow(FOLLOW_param_in_set_action2068);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal75=(IToken)Match(input,59,FOLLOW_59_in_set_action2070); 
                    		char_literal75_tree = (object)adaptor.Create(char_literal75);
                    		adaptor.AddChild(root_0, char_literal75_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:417:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action2079);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	 retval.action =  new SetAction("this", ((p != null) ? p.p : default(Param))); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "set_action"

    public class raise_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "raise_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:420:1: raise_action returns [Action action] : target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' ;
    public GbsParser.raise_action_return raise_action() // throws RecognitionException [1]
    {   
        GbsParser.raise_action_return retval = new GbsParser.raise_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e = null;
        IToken ACTION_RAISE76 = null;
        IToken char_literal77 = null;
        IToken char_literal78 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object e_tree=null;
        object ACTION_RAISE76_tree=null;
        object char_literal77_tree=null;
        object char_literal78_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:2: (target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:4: target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_raise_action2139);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_RAISE76=(IToken)Match(input,ACTION_RAISE,FOLLOW_ACTION_RAISE_in_raise_action2141); 
            		ACTION_RAISE76_tree = (object)adaptor.Create(ACTION_RAISE76);
            		adaptor.AddChild(root_0, ACTION_RAISE76_tree);

            	char_literal77=(IToken)Match(input,58,FOLLOW_58_in_raise_action2143); 
            		char_literal77_tree = (object)adaptor.Create(char_literal77);
            		adaptor.AddChild(root_0, char_literal77_tree);

            	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_raise_action2147); 
            		e_tree = (object)adaptor.Create(e);
            		adaptor.AddChild(root_0, e_tree);

            	char_literal78=(IToken)Match(input,59,FOLLOW_59_in_raise_action2149); 
            		char_literal78_tree = (object)adaptor.Create(char_literal78);
            		adaptor.AddChild(root_0, char_literal78_tree);

            	 retval.action =  new RaiseAction(((target != null) ? target.target : default(String)), e.Text); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "raise_action"

    public class trigger_return : ParserRuleReturnScope
    {
        public Trigger t;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "trigger"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:424:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
    public GbsParser.trigger_return trigger() // throws RecognitionException [1]
    {   
        GbsParser.trigger_return retval = new GbsParser.trigger_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken time = null;
        IToken period = null;
        IToken scroll = null;
        IToken anim = null;
        IToken e = null;
        IToken TRIGGER_INIT79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken TRIGGER_CLEANUP82 = null;
        IToken char_literal83 = null;
        IToken char_literal84 = null;
        IToken TRIGGER_TIME85 = null;
        IToken char_literal86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken char_literal89 = null;
        IToken TRIGGER_PERIODIC90 = null;
        IToken char_literal91 = null;
        IToken char_literal92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        IToken TRIGGER_SCROLLING95 = null;
        IToken char_literal96 = null;
        IToken char_literal97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        IToken TRIGGER_ANIMATION_END100 = null;
        IToken char_literal101 = null;
        IToken char_literal102 = null;
        IToken char_literal103 = null;
        IToken char_literal104 = null;
        IToken TRIGGER_EVENT105 = null;
        IToken char_literal106 = null;
        IToken char_literal107 = null;
        IToken char_literal108 = null;
        IToken char_literal109 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object period_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object TRIGGER_CLEANUP82_tree=null;
        object char_literal83_tree=null;
        object char_literal84_tree=null;
        object TRIGGER_TIME85_tree=null;
        object char_literal86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object char_literal89_tree=null;
        object TRIGGER_PERIODIC90_tree=null;
        object char_literal91_tree=null;
        object char_literal92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;
        object TRIGGER_SCROLLING95_tree=null;
        object char_literal96_tree=null;
        object char_literal97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;
        object TRIGGER_ANIMATION_END100_tree=null;
        object char_literal101_tree=null;
        object char_literal102_tree=null;
        object char_literal103_tree=null;
        object char_literal104_tree=null;
        object TRIGGER_EVENT105_tree=null;
        object char_literal106_tree=null;
        object char_literal107_tree=null;
        object char_literal108_tree=null;
        object char_literal109_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
            int alt18 = 7;
            switch ( input.LA(1) ) 
            {
            case TRIGGER_INIT:
            	{
                alt18 = 1;
                }
                break;
            case TRIGGER_CLEANUP:
            	{
                alt18 = 2;
                }
                break;
            case TRIGGER_TIME:
            	{
                alt18 = 3;
                }
                break;
            case TRIGGER_PERIODIC:
            	{
                alt18 = 4;
                }
                break;
            case TRIGGER_SCROLLING:
            	{
                alt18 = 5;
                }
                break;
            case TRIGGER_ANIMATION_END:
            	{
                alt18 = 6;
                }
                break;
            case TRIGGER_EVENT:
            	{
                alt18 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("", 18, 0, input);

            	    throw nvae_d18s0;
            }

            switch (alt18) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT79=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger2167); 
                    		TRIGGER_INIT79_tree = (object)adaptor.Create(TRIGGER_INIT79);
                    		adaptor.AddChild(root_0, TRIGGER_INIT79_tree);

                    	char_literal80=(IToken)Match(input,56,FOLLOW_56_in_trigger2169); 
                    		char_literal80_tree = (object)adaptor.Create(char_literal80);
                    		adaptor.AddChild(root_0, char_literal80_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2173);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal81=(IToken)Match(input,57,FOLLOW_57_in_trigger2175); 
                    		char_literal81_tree = (object)adaptor.Create(char_literal81);
                    		adaptor.AddChild(root_0, char_literal81_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP82=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2211); 
                    		TRIGGER_CLEANUP82_tree = (object)adaptor.Create(TRIGGER_CLEANUP82);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP82_tree);

                    	char_literal83=(IToken)Match(input,56,FOLLOW_56_in_trigger2213); 
                    		char_literal83_tree = (object)adaptor.Create(char_literal83);
                    		adaptor.AddChild(root_0, char_literal83_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2217);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal84=(IToken)Match(input,57,FOLLOW_57_in_trigger2219); 
                    		char_literal84_tree = (object)adaptor.Create(char_literal84);
                    		adaptor.AddChild(root_0, char_literal84_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:427:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME85=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2252); 
                    		TRIGGER_TIME85_tree = (object)adaptor.Create(TRIGGER_TIME85);
                    		adaptor.AddChild(root_0, TRIGGER_TIME85_tree);

                    	char_literal86=(IToken)Match(input,58,FOLLOW_58_in_trigger2254); 
                    		char_literal86_tree = (object)adaptor.Create(char_literal86);
                    		adaptor.AddChild(root_0, char_literal86_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2258); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal87=(IToken)Match(input,59,FOLLOW_59_in_trigger2260); 
                    		char_literal87_tree = (object)adaptor.Create(char_literal87);
                    		adaptor.AddChild(root_0, char_literal87_tree);

                    	char_literal88=(IToken)Match(input,56,FOLLOW_56_in_trigger2262); 
                    		char_literal88_tree = (object)adaptor.Create(char_literal88);
                    		adaptor.AddChild(root_0, char_literal88_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2266);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal89=(IToken)Match(input,57,FOLLOW_57_in_trigger2268); 
                    		char_literal89_tree = (object)adaptor.Create(char_literal89);
                    		adaptor.AddChild(root_0, char_literal89_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:428:4: TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_PERIODIC90=(IToken)Match(input,TRIGGER_PERIODIC,FOLLOW_TRIGGER_PERIODIC_in_trigger2284); 
                    		TRIGGER_PERIODIC90_tree = (object)adaptor.Create(TRIGGER_PERIODIC90);
                    		adaptor.AddChild(root_0, TRIGGER_PERIODIC90_tree);

                    	char_literal91=(IToken)Match(input,58,FOLLOW_58_in_trigger2286); 
                    		char_literal91_tree = (object)adaptor.Create(char_literal91);
                    		adaptor.AddChild(root_0, char_literal91_tree);

                    	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2290); 
                    		period_tree = (object)adaptor.Create(period);
                    		adaptor.AddChild(root_0, period_tree);

                    	char_literal92=(IToken)Match(input,59,FOLLOW_59_in_trigger2292); 
                    		char_literal92_tree = (object)adaptor.Create(char_literal92);
                    		adaptor.AddChild(root_0, char_literal92_tree);

                    	char_literal93=(IToken)Match(input,56,FOLLOW_56_in_trigger2294); 
                    		char_literal93_tree = (object)adaptor.Create(char_literal93);
                    		adaptor.AddChild(root_0, char_literal93_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2298);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal94=(IToken)Match(input,57,FOLLOW_57_in_trigger2300); 
                    		char_literal94_tree = (object)adaptor.Create(char_literal94);
                    		adaptor.AddChild(root_0, char_literal94_tree);

                    	 retval.t =  new PeriodicTrigger(float.Parse(period.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:429:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING95=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2307); 
                    		TRIGGER_SCROLLING95_tree = (object)adaptor.Create(TRIGGER_SCROLLING95);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING95_tree);

                    	char_literal96=(IToken)Match(input,58,FOLLOW_58_in_trigger2309); 
                    		char_literal96_tree = (object)adaptor.Create(char_literal96);
                    		adaptor.AddChild(root_0, char_literal96_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2313); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal97=(IToken)Match(input,59,FOLLOW_59_in_trigger2315); 
                    		char_literal97_tree = (object)adaptor.Create(char_literal97);
                    		adaptor.AddChild(root_0, char_literal97_tree);

                    	char_literal98=(IToken)Match(input,56,FOLLOW_56_in_trigger2317); 
                    		char_literal98_tree = (object)adaptor.Create(char_literal98);
                    		adaptor.AddChild(root_0, char_literal98_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2321);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal99=(IToken)Match(input,57,FOLLOW_57_in_trigger2323); 
                    		char_literal99_tree = (object)adaptor.Create(char_literal99);
                    		adaptor.AddChild(root_0, char_literal99_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:430:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END100=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2332); 
                    		TRIGGER_ANIMATION_END100_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END100);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END100_tree);

                    	char_literal101=(IToken)Match(input,58,FOLLOW_58_in_trigger2334); 
                    		char_literal101_tree = (object)adaptor.Create(char_literal101);
                    		adaptor.AddChild(root_0, char_literal101_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2338); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal102=(IToken)Match(input,59,FOLLOW_59_in_trigger2340); 
                    		char_literal102_tree = (object)adaptor.Create(char_literal102);
                    		adaptor.AddChild(root_0, char_literal102_tree);

                    	char_literal103=(IToken)Match(input,56,FOLLOW_56_in_trigger2342); 
                    		char_literal103_tree = (object)adaptor.Create(char_literal103);
                    		adaptor.AddChild(root_0, char_literal103_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2346);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal104=(IToken)Match(input,57,FOLLOW_57_in_trigger2348); 
                    		char_literal104_tree = (object)adaptor.Create(char_literal104);
                    		adaptor.AddChild(root_0, char_literal104_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:431:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT105=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2355); 
                    		TRIGGER_EVENT105_tree = (object)adaptor.Create(TRIGGER_EVENT105);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT105_tree);

                    	char_literal106=(IToken)Match(input,58,FOLLOW_58_in_trigger2357); 
                    		char_literal106_tree = (object)adaptor.Create(char_literal106);
                    		adaptor.AddChild(root_0, char_literal106_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2361); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal107=(IToken)Match(input,59,FOLLOW_59_in_trigger2363); 
                    		char_literal107_tree = (object)adaptor.Create(char_literal107);
                    		adaptor.AddChild(root_0, char_literal107_tree);

                    	char_literal108=(IToken)Match(input,56,FOLLOW_56_in_trigger2365); 
                    		char_literal108_tree = (object)adaptor.Create(char_literal108);
                    		adaptor.AddChild(root_0, char_literal108_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2369);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal109=(IToken)Match(input,57,FOLLOW_57_in_trigger2371); 
                    		char_literal109_tree = (object)adaptor.Create(char_literal109);
                    		adaptor.AddChild(root_0, char_literal109_tree);

                    	 retval.t =  new EventTrigger(e.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "trigger"

    // Delegated rules


   	protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
    	this.dfa15 = new DFA15(this);
	}

    const string DFA15_eotS =
        "\x0c\uffff";
    const string DFA15_eofS =
        "\x0c\uffff";
    const string DFA15_minS =
        "\x01\x04\x01\x13\x01\uffff\x01\x13\x08\uffff";
    const string DFA15_maxS =
        "\x01\x31\x01\x1b\x01\uffff\x01\x1b\x08\uffff";
    const string DFA15_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09";
    const string DFA15_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x01\x07\uffff\x07\x0a\x01\x04\x01\x05\x01\x06\x01\x07"+
            "\x01\x08\x01\x09\x01\x02\x01\x0a\x01\x0b\x15\uffff\x01\x03",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x02\x01"+
            "\x0a\x01\x0b",
            "",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x02\x01"+
            "\x0a\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "375:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_NUMBER_in_formula937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_DOWN_in_formula944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_UP_in_formula951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_LEFT_in_formula958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_RIGHT_in_formula965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_formula972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_gbs1001 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_fps_param_in_param1021 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param1037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param1047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param1058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param1072 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param1113 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_fps_param1115 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param1119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1136 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_gamearea_param1138 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1160 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_position_param1162 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1184 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_speed_param1186 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1208 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_animation_param1210 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1232 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_color_param1234 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1256 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_scrolling_param1258 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1262 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_scrolling_param1264 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_classdef_in_classdef1299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_classdef_in_classdef1308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_classdef_in_classdef1317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_classdef_in_classdef1326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_classdef_in_classdef1335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_classdef_in_classdef1344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_classdef_in_classdef1353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_classdef_content1368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_classdef_content1384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1409 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_engine_classdef1411 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_engine_classdef1413 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_engine_classdef1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_PLAYER_in_player_classdef1434 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_classdef1438 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_player_classdef1440 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_player_classdef1442 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_player_classdef1445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1462 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1466 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_enemy_classdef1468 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_enemy_classdef1470 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_enemy_classdef1473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1490 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1494 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_bullet_classdef1496 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_bullet_classdef1498 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_bullet_classdef1501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1519 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_classdef1523 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_script_classdef1525 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_script_classdef1527 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_script_classdef1530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_STATE_in_state_classdef1547 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_classdef1551 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_state_classdef1553 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_state_classdef1555 = new BitSet(new ulong[]{0x02000007F0000FE0UL});
    public static readonly BitSet FOLLOW_57_in_state_classdef1558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_EVENT_in_event_classdef1577 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_classdef1581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1610 = new BitSet(new ulong[]{0x000200000FFFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target1628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action1673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action1682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_action_in_action1698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action1709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action1730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action1748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action1768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action1785 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_raise_action_in_action1805 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action1827 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1829 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_play_animation_action1831 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action1835 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_play_animation_action1837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action1857 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action1859 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_periodic_action1861 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action1865 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_periodic_action1867 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_periodic_action1869 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action1873 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_periodic_action1875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_action1895 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_in_fire_action1897 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_fire_action1899 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_action1903 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_fire_action1905 = new BitSet(new ulong[]{0x000008F800000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_action1909 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_fire_action1911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action1931 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action1933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action1953 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action1955 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_start_action1957 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action1961 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_start_action1963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action1982 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action1984 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_stop_action1986 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action1990 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_stop_action1992 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action2013 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action2015 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_summon_action2017 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action2021 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_summon_action2023 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2027 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_summon_action2031 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action2035 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_summon_action2037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action2060 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action2062 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_set_action2064 = new BitSet(new ulong[]{0x000200000407F010UL});
    public static readonly BitSet FOLLOW_param_in_set_action2068 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_set_action2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action2079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_raise_action2139 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ACTION_RAISE_in_raise_action2141 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_raise_action2143 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_raise_action2147 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_raise_action2149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger2167 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2169 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2173 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2211 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2213 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2217 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2252 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_trigger2254 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2258 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2260 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2262 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2266 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_PERIODIC_in_trigger2284 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_trigger2286 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2290 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2292 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2294 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2298 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2307 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_trigger2309 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2313 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2315 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2317 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2321 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2332 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_trigger2334 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2338 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2340 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2342 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2346 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2355 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_trigger2357 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2361 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2363 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_trigger2365 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2369 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_trigger2371 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}