// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-10-12 22:23:53
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  
	Gbe.Script 

{

using System.Collections.Generic;
using Gbe.Script.Actions;
using Action = Gbe.Script.Actions.Action;
using Gbe.Script.Classdefs;
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
		"ACTION_FIRE_AT_PLAYER", 
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

    public const int DIRECTION = 39;
    public const int ACTION_SET = 26;
    public const int POINT = 41;
    public const int TRIGGER_SCROLLING = 32;
    public const int CLASSDEF_SCRIPT = 9;
    public const int EOF = -1;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 36;
    public const int CLASSDEF_BULLET = 7;
    public const int TRIGGER_CLEANUP = 29;
    public const int ML_COMMENT = 47;
    public const int PARAM_ANIMATION = 17;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int INSTANCE_IDENTIFIER = 44;
    public const int T__54 = 54;
    public const int TRIGGER_INIT = 28;
    public const int ACTION_START = 22;
    public const int THIS = 4;
    public const int RECTANGLE = 42;
    public const int CLASSDEF_PLAYER = 6;
    public const int PARAM_POSITION = 14;
    public const int DIGIT = 40;
    public const int CLASSDEF_EVENT = 11;
    public const int T__50 = 50;
    public const int ACTION_PERIODIC = 19;
    public const int PARAM_GAMEAREA = 13;
    public const int PARAM_FPS = 12;
    public const int CLASSDEF_ENEMY = 8;
    public const int T__49 = 49;
    public const int ACTION_FIRE_AT_PLAYER = 20;
    public const int ACTION_SUMMON = 24;
    public const int NUMBER = 38;
    public const int WHITESPACE = 46;
    public const int TRIGGER_TIME = 30;
    public const int HEX_DIGIT = 35;
    public const int ACTION_STOP = 23;
    public const int TRIGGER_PERIODIC = 31;
    public const int TRIGGER_ANIMATION_END = 33;
    public const int TRIGGER_EVENT = 34;
    public const int CLASSDEF_STATE = 10;
    public const int CARDINAL_DIRECTION = 37;
    public const int PARAM_COLOR = 15;
    public const int PARAM_SPEED = 16;
    public const int CLASS_IDENTIFIER = 43;
    public const int ACTION_RAISE = 27;
    public const int SL_COMMENT = 48;
    public const int ACTION_DIE = 21;
    public const int CLASSDEF_ENGINE = 5;
    public const int ACTION_PLAY_ANIMATION = 25;
    public const int STRING = 45;

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:224:1: gbs returns [Gbs s] : ( classdef )* ;
    public GbsParser.gbs_return gbs() // throws RecognitionException [1]
    {   
        gbs_stack.Push(new gbs_scope());
        GbsParser.gbs_return retval = new GbsParser.gbs_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.classdef_return classdef1 = default(GbsParser.classdef_return);



         
        	((gbs_scope)gbs_stack.Peek()).classdefs =  new List<Classdef>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:233:2: ( ( classdef )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:233:4: ( classdef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:233:4: ( classdef )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= CLASSDEF_ENGINE && LA1_0 <= CLASSDEF_EVENT)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:233:4: classdef
            			    {
            			    	PushFollow(FOLLOW_classdef_in_gbs891);
            			    	classdef1 = classdef();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:236:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:237:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param )
            int alt2 = 7;
            switch ( input.LA(1) ) 
            {
            case PARAM_FPS:
            	{
                alt2 = 1;
                }
                break;
            case PARAM_GAMEAREA:
            	{
                alt2 = 2;
                }
                break;
            case PARAM_POSITION:
            	{
                alt2 = 3;
                }
                break;
            case PARAM_SPEED:
            	{
                alt2 = 4;
                }
                break;
            case PARAM_ANIMATION:
            	{
                alt2 = 5;
                }
                break;
            case PARAM_COLOR:
            	{
                alt2 = 6;
                }
                break;
            case PARAM_SCROLLING:
            	{
                alt2 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:237:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param911);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:238:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param927);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:239:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param937);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:240:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param948);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:241:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param962);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:242:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param972);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:243:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param986);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:246:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
    public GbsParser.fps_param_return fps_param() // throws RecognitionException [1]
    {   
        GbsParser.fps_param_return retval = new GbsParser.fps_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken fps = null;
        IToken PARAM_FPS2 = null;
        IToken char_literal3 = null;

        object fps_tree=null;
        object PARAM_FPS2_tree=null;
        object char_literal3_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:247:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:247:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS2=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param1003); 
            		PARAM_FPS2_tree = (object)adaptor.Create(PARAM_FPS2);
            		adaptor.AddChild(root_0, PARAM_FPS2_tree);

            	char_literal3=(IToken)Match(input,49,FOLLOW_49_in_fps_param1005); 
            		char_literal3_tree = (object)adaptor.Create(char_literal3);
            		adaptor.AddChild(root_0, char_literal3_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param1009); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:250:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
    public GbsParser.gamearea_param_return gamearea_param() // throws RecognitionException [1]
    {   
        GbsParser.gamearea_param_return retval = new GbsParser.gamearea_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken area = null;
        IToken PARAM_GAMEAREA4 = null;
        IToken char_literal5 = null;

        object area_tree=null;
        object PARAM_GAMEAREA4_tree=null;
        object char_literal5_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:251:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:251:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA4=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1026); 
            		PARAM_GAMEAREA4_tree = (object)adaptor.Create(PARAM_GAMEAREA4);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA4_tree);

            	char_literal5=(IToken)Match(input,49,FOLLOW_49_in_gamearea_param1028); 
            		char_literal5_tree = (object)adaptor.Create(char_literal5);
            		adaptor.AddChild(root_0, char_literal5_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1032); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:254:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
    public GbsParser.position_param_return position_param() // throws RecognitionException [1]
    {   
        GbsParser.position_param_return retval = new GbsParser.position_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken pos = null;
        IToken PARAM_POSITION6 = null;
        IToken char_literal7 = null;

        object pos_tree=null;
        object PARAM_POSITION6_tree=null;
        object char_literal7_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION6=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1050); 
            		PARAM_POSITION6_tree = (object)adaptor.Create(PARAM_POSITION6);
            		adaptor.AddChild(root_0, PARAM_POSITION6_tree);

            	char_literal7=(IToken)Match(input,49,FOLLOW_49_in_position_param1052); 
            		char_literal7_tree = (object)adaptor.Create(char_literal7);
            		adaptor.AddChild(root_0, char_literal7_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1056); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:258:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
    public GbsParser.speed_param_return speed_param() // throws RecognitionException [1]
    {   
        GbsParser.speed_param_return retval = new GbsParser.speed_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken speed = null;
        IToken PARAM_SPEED8 = null;
        IToken char_literal9 = null;

        object speed_tree=null;
        object PARAM_SPEED8_tree=null;
        object char_literal9_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:259:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:259:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED8=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1074); 
            		PARAM_SPEED8_tree = (object)adaptor.Create(PARAM_SPEED8);
            		adaptor.AddChild(root_0, PARAM_SPEED8_tree);

            	char_literal9=(IToken)Match(input,49,FOLLOW_49_in_speed_param1076); 
            		char_literal9_tree = (object)adaptor.Create(char_literal9);
            		adaptor.AddChild(root_0, char_literal9_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1080); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:262:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
    public GbsParser.animation_param_return animation_param() // throws RecognitionException [1]
    {   
        GbsParser.animation_param_return retval = new GbsParser.animation_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken PARAM_ANIMATION10 = null;
        IToken char_literal11 = null;

        object anim_tree=null;
        object PARAM_ANIMATION10_tree=null;
        object char_literal11_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION10=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1098); 
            		PARAM_ANIMATION10_tree = (object)adaptor.Create(PARAM_ANIMATION10);
            		adaptor.AddChild(root_0, PARAM_ANIMATION10_tree);

            	char_literal11=(IToken)Match(input,49,FOLLOW_49_in_animation_param1100); 
            		char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1104); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:266:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
    public GbsParser.color_param_return color_param() // throws RecognitionException [1]
    {   
        GbsParser.color_param_return retval = new GbsParser.color_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken color = null;
        IToken PARAM_COLOR12 = null;
        IToken char_literal13 = null;

        object color_tree=null;
        object PARAM_COLOR12_tree=null;
        object char_literal13_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:267:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:267:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR12=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1122); 
            		PARAM_COLOR12_tree = (object)adaptor.Create(PARAM_COLOR12);
            		adaptor.AddChild(root_0, PARAM_COLOR12_tree);

            	char_literal13=(IToken)Match(input,49,FOLLOW_49_in_color_param1124); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1128); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:270:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
    public GbsParser.scrolling_param_return scrolling_param() // throws RecognitionException [1]
    {   
        GbsParser.scrolling_param_return retval = new GbsParser.scrolling_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken dir = null;
        IToken speed = null;
        IToken PARAM_SCROLLING14 = null;
        IToken char_literal15 = null;
        IToken char_literal16 = null;

        object dir_tree=null;
        object speed_tree=null;
        object PARAM_SCROLLING14_tree=null;
        object char_literal15_tree=null;
        object char_literal16_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:271:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:271:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING14=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1146); 
            		PARAM_SCROLLING14_tree = (object)adaptor.Create(PARAM_SCROLLING14);
            		adaptor.AddChild(root_0, PARAM_SCROLLING14_tree);

            	char_literal15=(IToken)Match(input,49,FOLLOW_49_in_scrolling_param1148); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1152); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal16=(IToken)Match(input,50,FOLLOW_50_in_scrolling_param1154); 
            		char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1158); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:274:1: classdef returns [Classdef en] : (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:285:2: (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef )
            int alt3 = 7;
            switch ( input.LA(1) ) 
            {
            case CLASSDEF_ENGINE:
            	{
                alt3 = 1;
                }
                break;
            case CLASSDEF_PLAYER:
            	{
                alt3 = 2;
                }
                break;
            case CLASSDEF_BULLET:
            	{
                alt3 = 3;
                }
                break;
            case CLASSDEF_ENEMY:
            	{
                alt3 = 4;
                }
                break;
            case CLASSDEF_EVENT:
            	{
                alt3 = 5;
                }
                break;
            case CLASSDEF_STATE:
            	{
                alt3 = 6;
                }
                break;
            case CLASSDEF_SCRIPT:
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:285:4: ee= engine_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_classdef_in_classdef1189);
                    	ee = engine_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:286:4: pe= player_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_classdef_in_classdef1198);
                    	pe = player_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:287:4: be= bullet_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_classdef_in_classdef1207);
                    	be = bullet_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:288:4: ene= enemy_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_classdef_in_classdef1216);
                    	ene = enemy_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:289:4: eve= event_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_classdef_in_classdef1225);
                    	eve = event_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:290:4: ste= state_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_classdef_in_classdef1234);
                    	ste = state_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:4: se= script_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_classdef_in_classdef1243);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:294:1: classdef_content : (t= trigger | se= classdef );
    public GbsParser.classdef_content_return classdef_content() // throws RecognitionException [1]
    {   
        GbsParser.classdef_content_return retval = new GbsParser.classdef_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.classdef_return se = default(GbsParser.classdef_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:295:2: (t= trigger | se= classdef )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= TRIGGER_INIT && LA4_0 <= TRIGGER_EVENT)) )
            {
                alt4 = 1;
            }
            else if ( ((LA4_0 >= CLASSDEF_ENGINE && LA4_0 <= CLASSDEF_EVENT)) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:295:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_classdef_content1258);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:296:4: se= classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classdef_in_classdef_content1274);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:299:1: engine_classdef returns [Classdef en] : CLASSDEF_ENGINE '{' ( classdef_content )* '}' ;
    public GbsParser.engine_classdef_return engine_classdef() // throws RecognitionException [1]
    {   
        GbsParser.engine_classdef_return retval = new GbsParser.engine_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASSDEF_ENGINE17 = null;
        IToken char_literal18 = null;
        IToken char_literal20 = null;
        GbsParser.classdef_content_return classdef_content19 = default(GbsParser.classdef_content_return);


        object CLASSDEF_ENGINE17_tree=null;
        object char_literal18_tree=null;
        object char_literal20_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:300:2: ( CLASSDEF_ENGINE '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:300:4: CLASSDEF_ENGINE '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENGINE17=(IToken)Match(input,CLASSDEF_ENGINE,FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1299); 
            		CLASSDEF_ENGINE17_tree = (object)adaptor.Create(CLASSDEF_ENGINE17);
            		adaptor.AddChild(root_0, CLASSDEF_ENGINE17_tree);

            	char_literal18=(IToken)Match(input,51,FOLLOW_51_in_engine_classdef1301); 
            		char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:300:24: ( classdef_content )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= CLASSDEF_ENGINE && LA5_0 <= CLASSDEF_EVENT) || (LA5_0 >= TRIGGER_INIT && LA5_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:300:24: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_engine_classdef1303);
            			    	classdef_content19 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal20=(IToken)Match(input,52,FOLLOW_52_in_engine_classdef1306); 
            		char_literal20_tree = (object)adaptor.Create(char_literal20);
            		adaptor.AddChild(root_0, char_literal20_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:303:1: player_classdef returns [Classdef en] : CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.player_classdef_return player_classdef() // throws RecognitionException [1]
    {   
        GbsParser.player_classdef_return retval = new GbsParser.player_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_PLAYER21 = null;
        IToken char_literal22 = null;
        IToken char_literal24 = null;
        GbsParser.classdef_content_return classdef_content23 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_PLAYER21_tree=null;
        object char_literal22_tree=null;
        object char_literal24_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:304:2: ( CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:304:4: CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_PLAYER21=(IToken)Match(input,CLASSDEF_PLAYER,FOLLOW_CLASSDEF_PLAYER_in_player_classdef1324); 
            		CLASSDEF_PLAYER21_tree = (object)adaptor.Create(CLASSDEF_PLAYER21);
            		adaptor.AddChild(root_0, CLASSDEF_PLAYER21_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_classdef1328); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal22=(IToken)Match(input,51,FOLLOW_51_in_player_classdef1330); 
            		char_literal22_tree = (object)adaptor.Create(char_literal22);
            		adaptor.AddChild(root_0, char_literal22_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:304:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:304:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_player_classdef1332);
            			    	classdef_content23 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content23.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal24=(IToken)Match(input,52,FOLLOW_52_in_player_classdef1335); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:307:1: enemy_classdef returns [Classdef en] : CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.enemy_classdef_return enemy_classdef() // throws RecognitionException [1]
    {   
        GbsParser.enemy_classdef_return retval = new GbsParser.enemy_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_ENEMY25 = null;
        IToken char_literal26 = null;
        IToken char_literal28 = null;
        GbsParser.classdef_content_return classdef_content27 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_ENEMY25_tree=null;
        object char_literal26_tree=null;
        object char_literal28_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:308:2: ( CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:308:4: CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENEMY25=(IToken)Match(input,CLASSDEF_ENEMY,FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1352); 
            		CLASSDEF_ENEMY25_tree = (object)adaptor.Create(CLASSDEF_ENEMY25);
            		adaptor.AddChild(root_0, CLASSDEF_ENEMY25_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1356); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal26=(IToken)Match(input,51,FOLLOW_51_in_enemy_classdef1358); 
            		char_literal26_tree = (object)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:308:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:308:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_enemy_classdef1360);
            			    	classdef_content27 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content27.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal28=(IToken)Match(input,52,FOLLOW_52_in_enemy_classdef1363); 
            		char_literal28_tree = (object)adaptor.Create(char_literal28);
            		adaptor.AddChild(root_0, char_literal28_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:311:1: bullet_classdef returns [Classdef en] : CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.bullet_classdef_return bullet_classdef() // throws RecognitionException [1]
    {   
        GbsParser.bullet_classdef_return retval = new GbsParser.bullet_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_BULLET29 = null;
        IToken char_literal30 = null;
        IToken char_literal32 = null;
        GbsParser.classdef_content_return classdef_content31 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_BULLET29_tree=null;
        object char_literal30_tree=null;
        object char_literal32_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:2: ( CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:4: CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_BULLET29=(IToken)Match(input,CLASSDEF_BULLET,FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1380); 
            		CLASSDEF_BULLET29_tree = (object)adaptor.Create(CLASSDEF_BULLET29);
            		adaptor.AddChild(root_0, CLASSDEF_BULLET29_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1384); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal30=(IToken)Match(input,51,FOLLOW_51_in_bullet_classdef1386); 
            		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		adaptor.AddChild(root_0, char_literal30_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_bullet_classdef1388);
            			    	classdef_content31 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content31.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal32=(IToken)Match(input,52,FOLLOW_52_in_bullet_classdef1391); 
            		char_literal32_tree = (object)adaptor.Create(char_literal32);
            		adaptor.AddChild(root_0, char_literal32_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:315:1: script_classdef returns [Classdef en] : CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.script_classdef_return script_classdef() // throws RecognitionException [1]
    {   
        GbsParser.script_classdef_return retval = new GbsParser.script_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_SCRIPT33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        GbsParser.classdef_content_return classdef_content35 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_SCRIPT33_tree=null;
        object char_literal34_tree=null;
        object char_literal36_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:2: ( CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:4: CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_SCRIPT33=(IToken)Match(input,CLASSDEF_SCRIPT,FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1409); 
            		CLASSDEF_SCRIPT33_tree = (object)adaptor.Create(CLASSDEF_SCRIPT33);
            		adaptor.AddChild(root_0, CLASSDEF_SCRIPT33_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_classdef1413); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal34=(IToken)Match(input,51,FOLLOW_51_in_script_classdef1415); 
            		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_script_classdef1417);
            			    	classdef_content35 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content35.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	char_literal36=(IToken)Match(input,52,FOLLOW_52_in_script_classdef1420); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:319:1: state_classdef returns [Classdef en] : CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.state_classdef_return state_classdef() // throws RecognitionException [1]
    {   
        GbsParser.state_classdef_return retval = new GbsParser.state_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_STATE37 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        GbsParser.classdef_content_return classdef_content39 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_STATE37_tree=null;
        object char_literal38_tree=null;
        object char_literal40_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:2: ( CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:4: CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_STATE37=(IToken)Match(input,CLASSDEF_STATE,FOLLOW_CLASSDEF_STATE_in_state_classdef1437); 
            		CLASSDEF_STATE37_tree = (object)adaptor.Create(CLASSDEF_STATE37);
            		adaptor.AddChild(root_0, CLASSDEF_STATE37_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_classdef1441); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal38=(IToken)Match(input,51,FOLLOW_51_in_state_classdef1443); 
            		char_literal38_tree = (object)adaptor.Create(char_literal38);
            		adaptor.AddChild(root_0, char_literal38_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_state_classdef1445);
            			    	classdef_content39 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal40=(IToken)Match(input,52,FOLLOW_52_in_state_classdef1448); 
            		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		adaptor.AddChild(root_0, char_literal40_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:323:1: event_classdef returns [Classdef en] : CLASSDEF_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_classdef_return event_classdef() // throws RecognitionException [1]
    {   
        GbsParser.event_classdef_return retval = new GbsParser.event_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_EVENT41 = null;

        object name_tree=null;
        object CLASSDEF_EVENT41_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:324:2: ( CLASSDEF_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:324:4: CLASSDEF_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_EVENT41=(IToken)Match(input,CLASSDEF_EVENT,FOLLOW_CLASSDEF_EVENT_in_event_classdef1467); 
            		CLASSDEF_EVENT41_tree = (object)adaptor.Create(CLASSDEF_EVENT41);
            		adaptor.AddChild(root_0, CLASSDEF_EVENT41_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_classdef1471); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:327:1: action_list returns [List<Action> actions] : ( action )* ;
    public GbsParser.action_list_return action_list() // throws RecognitionException [1]
    {   
        action_list_stack.Push(new action_list_scope());
        GbsParser.action_list_return retval = new GbsParser.action_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.action_return action42 = default(GbsParser.action_return);



         
        	((action_list_scope)action_list_stack.Peek()).list =  new List<Action>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:4: ( action )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == THIS || (LA11_0 >= PARAM_FPS && LA11_0 <= ACTION_RAISE) || LA11_0 == INSTANCE_IDENTIFIER) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1500);
            			    	action42 = action();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, action42.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
    public GbsParser.action_target_return action_target() // throws RecognitionException [1]
    {   
        GbsParser.action_target_return retval = new GbsParser.action_target_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ident = null;
        IToken THIS43 = null;

        object ident_tree=null;
        object THIS43_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == THIS || (LA13_0 >= ACTION_PERIODIC && LA13_0 <= ACTION_RAISE)) )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == INSTANCE_IDENTIFIER) )
            {
                alt13 = 2;
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:4: ( THIS )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == THIS) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:4: THIS
                    	        {
                    	        	THIS43=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target1518); 
                    	        		THIS43_tree = (object)adaptor.Create(THIS43);
                    	        		adaptor.AddChild(root_0, THIS43_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:341:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target1548); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:344:1: action : (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );
    public GbsParser.action_return action() // throws RecognitionException [1]
    {   
        GbsParser.action_return retval = new GbsParser.action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.play_animation_action_return pla = default(GbsParser.play_animation_action_return);

        GbsParser.periodic_action_return pa = default(GbsParser.periodic_action_return);

        GbsParser.fireAtPlayer_action_return fap = default(GbsParser.fireAtPlayer_action_return);

        GbsParser.die_action_return da = default(GbsParser.die_action_return);

        GbsParser.start_action_return sta = default(GbsParser.start_action_return);

        GbsParser.stop_action_return sa = default(GbsParser.stop_action_return);

        GbsParser.summon_action_return sum = default(GbsParser.summon_action_return);

        GbsParser.set_action_return sea = default(GbsParser.set_action_return);

        GbsParser.raise_action_return raa = default(GbsParser.raise_action_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:2: (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action )
            int alt14 = 9;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action1563);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:346:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action1572);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:4: fap= fireAtPlayer_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fireAtPlayer_action_in_action1588);
                    	fap = fireAtPlayer_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:348:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action1599);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:349:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action1620);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:350:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action1638);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action1658);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action1675);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:353:4: raa= raise_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_raise_action_in_action1695);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
    public GbsParser.play_animation_action_return play_animation_action() // throws RecognitionException [1]
    {   
        GbsParser.play_animation_action_return retval = new GbsParser.play_animation_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken ACTION_PLAY_ANIMATION44 = null;
        IToken char_literal45 = null;
        IToken char_literal46 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object anim_tree=null;
        object ACTION_PLAY_ANIMATION44_tree=null;
        object char_literal45_tree=null;
        object char_literal46_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:357:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:357:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action1717);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION44=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1719); 
            		ACTION_PLAY_ANIMATION44_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION44);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION44_tree);

            	char_literal45=(IToken)Match(input,53,FOLLOW_53_in_play_animation_action1721); 
            		char_literal45_tree = (object)adaptor.Create(char_literal45);
            		adaptor.AddChild(root_0, char_literal45_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action1725); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal46=(IToken)Match(input,54,FOLLOW_54_in_play_animation_action1727); 
            		char_literal46_tree = (object)adaptor.Create(char_literal46);
            		adaptor.AddChild(root_0, char_literal46_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken period = null;
        IToken ACTION_PERIODIC47 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object period_tree=null;
        object ACTION_PERIODIC47_tree=null;
        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:361:2: (target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:361:4: target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action1747);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC47=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action1749); 
            		ACTION_PERIODIC47_tree = (object)adaptor.Create(ACTION_PERIODIC47);
            		adaptor.AddChild(root_0, ACTION_PERIODIC47_tree);

            	char_literal48=(IToken)Match(input,53,FOLLOW_53_in_periodic_action1751); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

            	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action1755); 
            		period_tree = (object)adaptor.Create(period);
            		adaptor.AddChild(root_0, period_tree);

            	char_literal49=(IToken)Match(input,54,FOLLOW_54_in_periodic_action1757); 
            		char_literal49_tree = (object)adaptor.Create(char_literal49);
            		adaptor.AddChild(root_0, char_literal49_tree);

            	char_literal50=(IToken)Match(input,51,FOLLOW_51_in_periodic_action1759); 
            		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		adaptor.AddChild(root_0, char_literal50_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action1763);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal51=(IToken)Match(input,52,FOLLOW_52_in_periodic_action1765); 
            		char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);

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

    public class fireAtPlayer_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fireAtPlayer_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:1: fireAtPlayer_action returns [Action action] : target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')' ;
    public GbsParser.fireAtPlayer_action_return fireAtPlayer_action() // throws RecognitionException [1]
    {   
        GbsParser.fireAtPlayer_action_return retval = new GbsParser.fireAtPlayer_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE_AT_PLAYER52 = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object bullet_tree=null;
        object ACTION_FIRE_AT_PLAYER52_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:365:2: (target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:365:4: target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fireAtPlayer_action1785);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE_AT_PLAYER52=(IToken)Match(input,ACTION_FIRE_AT_PLAYER,FOLLOW_ACTION_FIRE_AT_PLAYER_in_fireAtPlayer_action1787); 
            		ACTION_FIRE_AT_PLAYER52_tree = (object)adaptor.Create(ACTION_FIRE_AT_PLAYER52);
            		adaptor.AddChild(root_0, ACTION_FIRE_AT_PLAYER52_tree);

            	char_literal53=(IToken)Match(input,53,FOLLOW_53_in_fireAtPlayer_action1789); 
            		char_literal53_tree = (object)adaptor.Create(char_literal53);
            		adaptor.AddChild(root_0, char_literal53_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fireAtPlayer_action1793); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal54=(IToken)Match(input,54,FOLLOW_54_in_fireAtPlayer_action1795); 
            		char_literal54_tree = (object)adaptor.Create(char_literal54);
            		adaptor.AddChild(root_0, char_literal54_tree);

            	 retval.action =  new FireAtPlayerAction(((target != null) ? target.target : default(String)), bullet.Text); 

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
    // $ANTLR end "fireAtPlayer_action"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE55 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE55_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action1815);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE55=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action1817); 
            		ACTION_DIE55_tree = (object)adaptor.Create(ACTION_DIE55);
            		adaptor.AddChild(root_0, ACTION_DIE55_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START56 = null;
        IToken char_literal57 = null;
        IToken char_literal58 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START56_tree=null;
        object char_literal57_tree=null;
        object char_literal58_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:373:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:373:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action1837);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START56=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action1839); 
            		ACTION_START56_tree = (object)adaptor.Create(ACTION_START56);
            		adaptor.AddChild(root_0, ACTION_START56_tree);

            	char_literal57=(IToken)Match(input,53,FOLLOW_53_in_start_action1841); 
            		char_literal57_tree = (object)adaptor.Create(char_literal57);
            		adaptor.AddChild(root_0, char_literal57_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action1845); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal58=(IToken)Match(input,54,FOLLOW_54_in_start_action1847); 
            		char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP59 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP59_tree=null;
        object char_literal60_tree=null;
        object char_literal61_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action1866);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP59=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action1868); 
            		ACTION_STOP59_tree = (object)adaptor.Create(ACTION_STOP59);
            		adaptor.AddChild(root_0, ACTION_STOP59_tree);

            	char_literal60=(IToken)Match(input,53,FOLLOW_53_in_stop_action1870); 
            		char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action1874); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal61=(IToken)Match(input,54,FOLLOW_54_in_stop_action1876); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:380:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON62_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action1897);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON62=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action1899); 
            		ACTION_SUMMON62_tree = (object)adaptor.Create(ACTION_SUMMON62);
            		adaptor.AddChild(root_0, ACTION_SUMMON62_tree);

            	char_literal63=(IToken)Match(input,53,FOLLOW_53_in_summon_action1901); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action1905); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal64=(IToken)Match(input,54,FOLLOW_54_in_summon_action1907); 
            		char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action1911); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:95: ( '{' a= action_list '}' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 51) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:97: '{' a= action_list '}'
            	        {
            	        	char_literal65=(IToken)Match(input,51,FOLLOW_51_in_summon_action1915); 
            	        		char_literal65_tree = (object)adaptor.Create(char_literal65);
            	        		adaptor.AddChild(root_0, char_literal65_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action1919);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal66=(IToken)Match(input,52,FOLLOW_52_in_summon_action1921); 
            	        		char_literal66_tree = (object)adaptor.Create(char_literal66);
            	        		adaptor.AddChild(root_0, char_literal66_tree);


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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:384:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET67 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET67_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:385:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == THIS || (LA16_0 >= ACTION_PERIODIC && LA16_0 <= ACTION_RAISE) || LA16_0 == INSTANCE_IDENTIFIER) )
            {
                alt16 = 1;
            }
            else if ( ((LA16_0 >= PARAM_FPS && LA16_0 <= PARAM_SCROLLING)) )
            {
                alt16 = 2;
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:385:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action1944);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET67=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action1946); 
                    		ACTION_SET67_tree = (object)adaptor.Create(ACTION_SET67);
                    		adaptor.AddChild(root_0, ACTION_SET67_tree);

                    	char_literal68=(IToken)Match(input,53,FOLLOW_53_in_set_action1948); 
                    		char_literal68_tree = (object)adaptor.Create(char_literal68);
                    		adaptor.AddChild(root_0, char_literal68_tree);

                    	PushFollow(FOLLOW_param_in_set_action1952);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal69=(IToken)Match(input,54,FOLLOW_54_in_set_action1954); 
                    		char_literal69_tree = (object)adaptor.Create(char_literal69);
                    		adaptor.AddChild(root_0, char_literal69_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:386:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action1963);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:389:1: raise_action returns [Action action] : target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' ;
    public GbsParser.raise_action_return raise_action() // throws RecognitionException [1]
    {   
        GbsParser.raise_action_return retval = new GbsParser.raise_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e = null;
        IToken ACTION_RAISE70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object e_tree=null;
        object ACTION_RAISE70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:2: (target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:4: target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_raise_action2023);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_RAISE70=(IToken)Match(input,ACTION_RAISE,FOLLOW_ACTION_RAISE_in_raise_action2025); 
            		ACTION_RAISE70_tree = (object)adaptor.Create(ACTION_RAISE70);
            		adaptor.AddChild(root_0, ACTION_RAISE70_tree);

            	char_literal71=(IToken)Match(input,53,FOLLOW_53_in_raise_action2027); 
            		char_literal71_tree = (object)adaptor.Create(char_literal71);
            		adaptor.AddChild(root_0, char_literal71_tree);

            	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_raise_action2031); 
            		e_tree = (object)adaptor.Create(e);
            		adaptor.AddChild(root_0, e_tree);

            	char_literal72=(IToken)Match(input,54,FOLLOW_54_in_raise_action2033); 
            		char_literal72_tree = (object)adaptor.Create(char_literal72);
            		adaptor.AddChild(root_0, char_literal72_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:393:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
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
        IToken TRIGGER_INIT73 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        IToken TRIGGER_CLEANUP76 = null;
        IToken char_literal77 = null;
        IToken char_literal78 = null;
        IToken TRIGGER_TIME79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken char_literal82 = null;
        IToken char_literal83 = null;
        IToken TRIGGER_PERIODIC84 = null;
        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken TRIGGER_SCROLLING89 = null;
        IToken char_literal90 = null;
        IToken char_literal91 = null;
        IToken char_literal92 = null;
        IToken char_literal93 = null;
        IToken TRIGGER_ANIMATION_END94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        IToken char_literal97 = null;
        IToken char_literal98 = null;
        IToken TRIGGER_EVENT99 = null;
        IToken char_literal100 = null;
        IToken char_literal101 = null;
        IToken char_literal102 = null;
        IToken char_literal103 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object period_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT73_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;
        object TRIGGER_CLEANUP76_tree=null;
        object char_literal77_tree=null;
        object char_literal78_tree=null;
        object TRIGGER_TIME79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object char_literal82_tree=null;
        object char_literal83_tree=null;
        object TRIGGER_PERIODIC84_tree=null;
        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object TRIGGER_SCROLLING89_tree=null;
        object char_literal90_tree=null;
        object char_literal91_tree=null;
        object char_literal92_tree=null;
        object char_literal93_tree=null;
        object TRIGGER_ANIMATION_END94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;
        object char_literal97_tree=null;
        object char_literal98_tree=null;
        object TRIGGER_EVENT99_tree=null;
        object char_literal100_tree=null;
        object char_literal101_tree=null;
        object char_literal102_tree=null;
        object char_literal103_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
            int alt17 = 7;
            switch ( input.LA(1) ) 
            {
            case TRIGGER_INIT:
            	{
                alt17 = 1;
                }
                break;
            case TRIGGER_CLEANUP:
            	{
                alt17 = 2;
                }
                break;
            case TRIGGER_TIME:
            	{
                alt17 = 3;
                }
                break;
            case TRIGGER_PERIODIC:
            	{
                alt17 = 4;
                }
                break;
            case TRIGGER_SCROLLING:
            	{
                alt17 = 5;
                }
                break;
            case TRIGGER_ANIMATION_END:
            	{
                alt17 = 6;
                }
                break;
            case TRIGGER_EVENT:
            	{
                alt17 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT73=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger2051); 
                    		TRIGGER_INIT73_tree = (object)adaptor.Create(TRIGGER_INIT73);
                    		adaptor.AddChild(root_0, TRIGGER_INIT73_tree);

                    	char_literal74=(IToken)Match(input,51,FOLLOW_51_in_trigger2053); 
                    		char_literal74_tree = (object)adaptor.Create(char_literal74);
                    		adaptor.AddChild(root_0, char_literal74_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2057);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal75=(IToken)Match(input,52,FOLLOW_52_in_trigger2059); 
                    		char_literal75_tree = (object)adaptor.Create(char_literal75);
                    		adaptor.AddChild(root_0, char_literal75_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:395:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP76=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2095); 
                    		TRIGGER_CLEANUP76_tree = (object)adaptor.Create(TRIGGER_CLEANUP76);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP76_tree);

                    	char_literal77=(IToken)Match(input,51,FOLLOW_51_in_trigger2097); 
                    		char_literal77_tree = (object)adaptor.Create(char_literal77);
                    		adaptor.AddChild(root_0, char_literal77_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2101);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal78=(IToken)Match(input,52,FOLLOW_52_in_trigger2103); 
                    		char_literal78_tree = (object)adaptor.Create(char_literal78);
                    		adaptor.AddChild(root_0, char_literal78_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:396:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME79=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2136); 
                    		TRIGGER_TIME79_tree = (object)adaptor.Create(TRIGGER_TIME79);
                    		adaptor.AddChild(root_0, TRIGGER_TIME79_tree);

                    	char_literal80=(IToken)Match(input,53,FOLLOW_53_in_trigger2138); 
                    		char_literal80_tree = (object)adaptor.Create(char_literal80);
                    		adaptor.AddChild(root_0, char_literal80_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2142); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal81=(IToken)Match(input,54,FOLLOW_54_in_trigger2144); 
                    		char_literal81_tree = (object)adaptor.Create(char_literal81);
                    		adaptor.AddChild(root_0, char_literal81_tree);

                    	char_literal82=(IToken)Match(input,51,FOLLOW_51_in_trigger2146); 
                    		char_literal82_tree = (object)adaptor.Create(char_literal82);
                    		adaptor.AddChild(root_0, char_literal82_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2150);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal83=(IToken)Match(input,52,FOLLOW_52_in_trigger2152); 
                    		char_literal83_tree = (object)adaptor.Create(char_literal83);
                    		adaptor.AddChild(root_0, char_literal83_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:397:4: TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_PERIODIC84=(IToken)Match(input,TRIGGER_PERIODIC,FOLLOW_TRIGGER_PERIODIC_in_trigger2168); 
                    		TRIGGER_PERIODIC84_tree = (object)adaptor.Create(TRIGGER_PERIODIC84);
                    		adaptor.AddChild(root_0, TRIGGER_PERIODIC84_tree);

                    	char_literal85=(IToken)Match(input,53,FOLLOW_53_in_trigger2170); 
                    		char_literal85_tree = (object)adaptor.Create(char_literal85);
                    		adaptor.AddChild(root_0, char_literal85_tree);

                    	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2174); 
                    		period_tree = (object)adaptor.Create(period);
                    		adaptor.AddChild(root_0, period_tree);

                    	char_literal86=(IToken)Match(input,54,FOLLOW_54_in_trigger2176); 
                    		char_literal86_tree = (object)adaptor.Create(char_literal86);
                    		adaptor.AddChild(root_0, char_literal86_tree);

                    	char_literal87=(IToken)Match(input,51,FOLLOW_51_in_trigger2178); 
                    		char_literal87_tree = (object)adaptor.Create(char_literal87);
                    		adaptor.AddChild(root_0, char_literal87_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2182);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal88=(IToken)Match(input,52,FOLLOW_52_in_trigger2184); 
                    		char_literal88_tree = (object)adaptor.Create(char_literal88);
                    		adaptor.AddChild(root_0, char_literal88_tree);

                    	 retval.t =  new PeriodicTrigger(float.Parse(period.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:398:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING89=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2191); 
                    		TRIGGER_SCROLLING89_tree = (object)adaptor.Create(TRIGGER_SCROLLING89);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING89_tree);

                    	char_literal90=(IToken)Match(input,53,FOLLOW_53_in_trigger2193); 
                    		char_literal90_tree = (object)adaptor.Create(char_literal90);
                    		adaptor.AddChild(root_0, char_literal90_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2197); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal91=(IToken)Match(input,54,FOLLOW_54_in_trigger2199); 
                    		char_literal91_tree = (object)adaptor.Create(char_literal91);
                    		adaptor.AddChild(root_0, char_literal91_tree);

                    	char_literal92=(IToken)Match(input,51,FOLLOW_51_in_trigger2201); 
                    		char_literal92_tree = (object)adaptor.Create(char_literal92);
                    		adaptor.AddChild(root_0, char_literal92_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2205);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal93=(IToken)Match(input,52,FOLLOW_52_in_trigger2207); 
                    		char_literal93_tree = (object)adaptor.Create(char_literal93);
                    		adaptor.AddChild(root_0, char_literal93_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:399:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END94=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2216); 
                    		TRIGGER_ANIMATION_END94_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END94);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END94_tree);

                    	char_literal95=(IToken)Match(input,53,FOLLOW_53_in_trigger2218); 
                    		char_literal95_tree = (object)adaptor.Create(char_literal95);
                    		adaptor.AddChild(root_0, char_literal95_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2222); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal96=(IToken)Match(input,54,FOLLOW_54_in_trigger2224); 
                    		char_literal96_tree = (object)adaptor.Create(char_literal96);
                    		adaptor.AddChild(root_0, char_literal96_tree);

                    	char_literal97=(IToken)Match(input,51,FOLLOW_51_in_trigger2226); 
                    		char_literal97_tree = (object)adaptor.Create(char_literal97);
                    		adaptor.AddChild(root_0, char_literal97_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2230);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal98=(IToken)Match(input,52,FOLLOW_52_in_trigger2232); 
                    		char_literal98_tree = (object)adaptor.Create(char_literal98);
                    		adaptor.AddChild(root_0, char_literal98_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:400:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT99=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2239); 
                    		TRIGGER_EVENT99_tree = (object)adaptor.Create(TRIGGER_EVENT99);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT99_tree);

                    	char_literal100=(IToken)Match(input,53,FOLLOW_53_in_trigger2241); 
                    		char_literal100_tree = (object)adaptor.Create(char_literal100);
                    		adaptor.AddChild(root_0, char_literal100_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2245); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal101=(IToken)Match(input,54,FOLLOW_54_in_trigger2247); 
                    		char_literal101_tree = (object)adaptor.Create(char_literal101);
                    		adaptor.AddChild(root_0, char_literal101_tree);

                    	char_literal102=(IToken)Match(input,51,FOLLOW_51_in_trigger2249); 
                    		char_literal102_tree = (object)adaptor.Create(char_literal102);
                    		adaptor.AddChild(root_0, char_literal102_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2253);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal103=(IToken)Match(input,52,FOLLOW_52_in_trigger2255); 
                    		char_literal103_tree = (object)adaptor.Create(char_literal103);
                    		adaptor.AddChild(root_0, char_literal103_tree);

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


   	protected DFA14 dfa14;
	private void InitializeCyclicDFAs()
	{
    	this.dfa14 = new DFA14(this);
	}

    const string DFA14_eotS =
        "\x0c\uffff";
    const string DFA14_eofS =
        "\x0c\uffff";
    const string DFA14_minS =
        "\x01\x04\x01\x13\x01\uffff\x01\x13\x08\uffff";
    const string DFA14_maxS =
        "\x01\x2c\x01\x1b\x01\uffff\x01\x1b\x08\uffff";
    const string DFA14_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09";
    const string DFA14_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x01\x07\uffff\x07\x0a\x01\x04\x01\x05\x01\x06\x01\x07"+
            "\x01\x08\x01\x09\x01\x02\x01\x0a\x01\x0b\x10\uffff\x01\x03",
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

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "344:1: action : (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_classdef_in_gbs891 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_fps_param_in_param911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param986 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param1003 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_fps_param1005 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param1009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1026 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_gamearea_param1028 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1050 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_position_param1052 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1074 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_speed_param1076 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1098 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_animation_param1100 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1122 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_color_param1124 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1146 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_scrolling_param1148 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1152 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_scrolling_param1154 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_classdef_in_classdef1189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_classdef_in_classdef1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_classdef_in_classdef1207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_classdef_in_classdef1216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_classdef_in_classdef1225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_classdef_in_classdef1234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_classdef_in_classdef1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_classdef_content1258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_classdef_content1274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1299 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_engine_classdef1301 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_engine_classdef1303 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_engine_classdef1306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_PLAYER_in_player_classdef1324 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_classdef1328 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_player_classdef1330 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_player_classdef1332 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_player_classdef1335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1352 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1356 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_enemy_classdef1358 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_enemy_classdef1360 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_enemy_classdef1363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1380 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1384 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_bullet_classdef1386 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_bullet_classdef1388 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_bullet_classdef1391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1409 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_classdef1413 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_script_classdef1415 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_script_classdef1417 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_script_classdef1420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_STATE_in_state_classdef1437 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_classdef1441 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_state_classdef1443 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_classdef_content_in_state_classdef1445 = new BitSet(new ulong[]{0x00100007F0000FE0UL});
    public static readonly BitSet FOLLOW_52_in_state_classdef1448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_EVENT_in_event_classdef1467 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_classdef1471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1500 = new BitSet(new ulong[]{0x000010000FFFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target1518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target1548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action1563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fireAtPlayer_action_in_action1588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action1599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action1620 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action1638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action1675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_raise_action_in_action1695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action1717 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1719 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_play_animation_action1721 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action1725 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_play_animation_action1727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action1747 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action1749 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_periodic_action1751 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action1755 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_periodic_action1757 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_periodic_action1759 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action1763 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_periodic_action1765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fireAtPlayer_action1785 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_AT_PLAYER_in_fireAtPlayer_action1787 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_fireAtPlayer_action1789 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fireAtPlayer_action1793 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_fireAtPlayer_action1795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action1815 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action1817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action1837 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action1839 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_start_action1841 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action1845 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_start_action1847 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action1866 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action1868 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_stop_action1870 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action1874 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_stop_action1876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action1897 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action1899 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_summon_action1901 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action1905 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_summon_action1907 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action1911 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_51_in_summon_action1915 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action1919 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_summon_action1921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action1944 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action1946 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_set_action1948 = new BitSet(new ulong[]{0x000010000407F010UL});
    public static readonly BitSet FOLLOW_param_in_set_action1952 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_set_action1954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action1963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_raise_action2023 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ACTION_RAISE_in_raise_action2025 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_raise_action2027 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_raise_action2031 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_raise_action2033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger2051 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2053 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2057 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2095 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2097 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2101 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2136 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_trigger2138 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2142 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_trigger2144 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2146 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2150 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_PERIODIC_in_trigger2168 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_trigger2170 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2174 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_trigger2176 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2178 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2182 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2191 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_trigger2193 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2197 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_trigger2199 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2201 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2205 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2216 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_trigger2218 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2222 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_trigger2224 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2226 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2230 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2239 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_trigger2241 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2245 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_trigger2247 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2249 = new BitSet(new ulong[]{0x000010000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2253 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2255 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}