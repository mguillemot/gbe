// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g 2008-10-05 22:26:52
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  
	Gbe.Compiler 

{

using System.Collections.Generic;
using Gbe.Compiler.Actions;
using Action = Gbe.Compiler.Actions.Action;
using Gbe.Compiler.Entities;
using Gbe.Compiler.Parameters;
using Gbe.Compiler.Triggers;


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
		"ENTITY_ENGINE", 
		"ENTITY_PLAYER", 
		"ENTITY_BULLET", 
		"ENTITY_ENEMY", 
		"ENTITY_SCRIPT", 
		"ENTITY_STATE", 
		"ENTITY_EVENT", 
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
		"TRIGGER_INIT", 
		"TRIGGER_CLEANUP", 
		"TRIGGER_TIME", 
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

    public const int DIRECTION = 37;
    public const int ACTION_SET = 26;
    public const int POINT = 39;
    public const int TRIGGER_SCROLLING = 30;
    public const int ENTITY_EVENT = 11;
    public const int EOF = -1;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 34;
    public const int TRIGGER_CLEANUP = 28;
    public const int ENTITY_ENEMY = 8;
    public const int ML_COMMENT = 45;
    public const int PARAM_ANIMATION = 17;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int INSTANCE_IDENTIFIER = 42;
    public const int ENTITY_SCRIPT = 9;
    public const int TRIGGER_INIT = 27;
    public const int ACTION_START = 22;
    public const int ENTITY_STATE = 10;
    public const int THIS = 4;
    public const int RECTANGLE = 40;
    public const int PARAM_POSITION = 14;
    public const int DIGIT = 38;
    public const int ENTITY_PLAYER = 6;
    public const int T__50 = 50;
    public const int ACTION_PERIODIC = 19;
    public const int ENTITY_BULLET = 7;
    public const int T__47 = 47;
    public const int PARAM_GAMEAREA = 13;
    public const int PARAM_FPS = 12;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int ACTION_FIRE_AT_PLAYER = 20;
    public const int ACTION_SUMMON = 24;
    public const int NUMBER = 36;
    public const int WHITESPACE = 44;
    public const int TRIGGER_TIME = 29;
    public const int HEX_DIGIT = 33;
    public const int ACTION_STOP = 23;
    public const int ENTITY_ENGINE = 5;
    public const int TRIGGER_ANIMATION_END = 31;
    public const int TRIGGER_EVENT = 32;
    public const int CARDINAL_DIRECTION = 35;
    public const int PARAM_COLOR = 15;
    public const int PARAM_SPEED = 16;
    public const int CLASS_IDENTIFIER = 41;
    public const int SL_COMMENT = 46;
    public const int ACTION_DIE = 21;
    public const int ACTION_PLAY_ANIMATION = 25;
    public const int STRING = 43;

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
		get { return "C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g"; }
    }


    protected class gbs_scope 
    {
        protected internal List<Entity> entities;
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:216:1: gbs returns [Gbs s] : ( entity )* ;
    public GbsParser.gbs_return gbs() // throws RecognitionException [1]
    {   
        gbs_stack.Push(new gbs_scope());
        GbsParser.gbs_return retval = new GbsParser.gbs_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.entity_return entity1 = default(GbsParser.entity_return);



         
        	((gbs_scope)gbs_stack.Peek()).entities =  new List<Entity>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:225:2: ( ( entity )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:225:4: ( entity )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:225:4: ( entity )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= ENTITY_ENGINE && LA1_0 <= ENTITY_EVENT)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:225:4: entity
            			    {
            			    	PushFollow(FOLLOW_entity_in_gbs867);
            			    	entity1 = entity();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	 retval.s =  new Gbs(((gbs_scope)gbs_stack.Peek()).entities); 

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:228:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:229:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:229:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param887);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:230:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param903);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:231:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param913);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:232:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param924);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:233:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param938);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:234:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param948);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:235:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param962);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:238:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:239:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:239:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS2=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param979); 
            		PARAM_FPS2_tree = (object)adaptor.Create(PARAM_FPS2);
            		adaptor.AddChild(root_0, PARAM_FPS2_tree);

            	char_literal3=(IToken)Match(input,47,FOLLOW_47_in_fps_param981); 
            		char_literal3_tree = (object)adaptor.Create(char_literal3);
            		adaptor.AddChild(root_0, char_literal3_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param985); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:242:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:243:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:243:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA4=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1002); 
            		PARAM_GAMEAREA4_tree = (object)adaptor.Create(PARAM_GAMEAREA4);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA4_tree);

            	char_literal5=(IToken)Match(input,47,FOLLOW_47_in_gamearea_param1004); 
            		char_literal5_tree = (object)adaptor.Create(char_literal5);
            		adaptor.AddChild(root_0, char_literal5_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1008); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:246:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:247:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:247:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION6=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1026); 
            		PARAM_POSITION6_tree = (object)adaptor.Create(PARAM_POSITION6);
            		adaptor.AddChild(root_0, PARAM_POSITION6_tree);

            	char_literal7=(IToken)Match(input,47,FOLLOW_47_in_position_param1028); 
            		char_literal7_tree = (object)adaptor.Create(char_literal7);
            		adaptor.AddChild(root_0, char_literal7_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1032); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:250:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:251:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:251:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED8=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1050); 
            		PARAM_SPEED8_tree = (object)adaptor.Create(PARAM_SPEED8);
            		adaptor.AddChild(root_0, PARAM_SPEED8_tree);

            	char_literal9=(IToken)Match(input,47,FOLLOW_47_in_speed_param1052); 
            		char_literal9_tree = (object)adaptor.Create(char_literal9);
            		adaptor.AddChild(root_0, char_literal9_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1056); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:254:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:255:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:255:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION10=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1074); 
            		PARAM_ANIMATION10_tree = (object)adaptor.Create(PARAM_ANIMATION10);
            		adaptor.AddChild(root_0, PARAM_ANIMATION10_tree);

            	char_literal11=(IToken)Match(input,47,FOLLOW_47_in_animation_param1076); 
            		char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1080); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:258:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:259:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:259:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR12=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1098); 
            		PARAM_COLOR12_tree = (object)adaptor.Create(PARAM_COLOR12);
            		adaptor.AddChild(root_0, PARAM_COLOR12_tree);

            	char_literal13=(IToken)Match(input,47,FOLLOW_47_in_color_param1100); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1104); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:262:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:263:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:263:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING14=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1122); 
            		PARAM_SCROLLING14_tree = (object)adaptor.Create(PARAM_SCROLLING14);
            		adaptor.AddChild(root_0, PARAM_SCROLLING14_tree);

            	char_literal15=(IToken)Match(input,47,FOLLOW_47_in_scrolling_param1124); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1128); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal16=(IToken)Match(input,48,FOLLOW_48_in_scrolling_param1130); 
            		char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1134); 
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

    protected class entity_scope 
    {
        protected internal List<Entity> subEntities;
        protected internal List<Trigger> triggers;
    }
    protected Stack entity_stack = new Stack();

    public class entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:266:1: entity returns [Entity en] : (ee= engine_entity | pe= player_entity | be= bullet_entity | ene= enemy_entity | eve= event_entity | ste= state_entity | se= script_entity );
    public GbsParser.entity_return entity() // throws RecognitionException [1]
    {   
        entity_stack.Push(new entity_scope());
        GbsParser.entity_return retval = new GbsParser.entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.engine_entity_return ee = default(GbsParser.engine_entity_return);

        GbsParser.player_entity_return pe = default(GbsParser.player_entity_return);

        GbsParser.bullet_entity_return be = default(GbsParser.bullet_entity_return);

        GbsParser.enemy_entity_return ene = default(GbsParser.enemy_entity_return);

        GbsParser.event_entity_return eve = default(GbsParser.event_entity_return);

        GbsParser.state_entity_return ste = default(GbsParser.state_entity_return);

        GbsParser.script_entity_return se = default(GbsParser.script_entity_return);



         
        	((entity_scope)entity_stack.Peek()).subEntities =  new List<Entity>(); 
        	((entity_scope)entity_stack.Peek()).triggers =  new List<Trigger>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:277:2: (ee= engine_entity | pe= player_entity | be= bullet_entity | ene= enemy_entity | eve= event_entity | ste= state_entity | se= script_entity )
            int alt3 = 7;
            switch ( input.LA(1) ) 
            {
            case ENTITY_ENGINE:
            	{
                alt3 = 1;
                }
                break;
            case ENTITY_PLAYER:
            	{
                alt3 = 2;
                }
                break;
            case ENTITY_BULLET:
            	{
                alt3 = 3;
                }
                break;
            case ENTITY_ENEMY:
            	{
                alt3 = 4;
                }
                break;
            case ENTITY_EVENT:
            	{
                alt3 = 5;
                }
                break;
            case ENTITY_STATE:
            	{
                alt3 = 6;
                }
                break;
            case ENTITY_SCRIPT:
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:277:4: ee= engine_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_entity_in_entity1165);
                    	ee = engine_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:278:4: pe= player_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_entity_in_entity1174);
                    	pe = player_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:279:4: be= bullet_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_entity_in_entity1183);
                    	be = bullet_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:280:4: ene= enemy_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_entity_in_entity1192);
                    	ene = enemy_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:281:4: eve= event_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_entity_in_entity1201);
                    	eve = event_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:282:4: ste= state_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_entity_in_entity1210);
                    	ste = state_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:283:4: se= script_entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_entity_in_entity1219);
                    	se = script_entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, se.Tree);
                    	 retval.en =  ((se != null) ? se.en : default(Entity)); ((gbs_scope)gbs_stack.Peek()).entities.Add(retval.en); 

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
            entity_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "entity"

    public class entity_content_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "entity_content"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:286:1: entity_content : (t= trigger | se= entity );
    public GbsParser.entity_content_return entity_content() // throws RecognitionException [1]
    {   
        GbsParser.entity_content_return retval = new GbsParser.entity_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.entity_return se = default(GbsParser.entity_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:287:2: (t= trigger | se= entity )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= TRIGGER_INIT && LA4_0 <= TRIGGER_EVENT)) )
            {
                alt4 = 1;
            }
            else if ( ((LA4_0 >= ENTITY_ENGINE && LA4_0 <= ENTITY_EVENT)) )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:287:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_entity_content1234);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((entity_scope)entity_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:288:4: se= entity
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_entity_in_entity_content1250);
                    	se = entity();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, se.Tree);
                    	 ((entity_scope)entity_stack.Peek()).subEntities.Add(((se != null) ? se.en : default(Entity))); 

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
    // $ANTLR end "entity_content"

    public class engine_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "engine_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:291:1: engine_entity returns [Entity en] : ENTITY_ENGINE '{' ( entity_content )* '}' ;
    public GbsParser.engine_entity_return engine_entity() // throws RecognitionException [1]
    {   
        GbsParser.engine_entity_return retval = new GbsParser.engine_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENTITY_ENGINE17 = null;
        IToken char_literal18 = null;
        IToken char_literal20 = null;
        GbsParser.entity_content_return entity_content19 = default(GbsParser.entity_content_return);


        object ENTITY_ENGINE17_tree=null;
        object char_literal18_tree=null;
        object char_literal20_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:292:2: ( ENTITY_ENGINE '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:292:4: ENTITY_ENGINE '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_ENGINE17=(IToken)Match(input,ENTITY_ENGINE,FOLLOW_ENTITY_ENGINE_in_engine_entity1275); 
            		ENTITY_ENGINE17_tree = (object)adaptor.Create(ENTITY_ENGINE17);
            		adaptor.AddChild(root_0, ENTITY_ENGINE17_tree);

            	char_literal18=(IToken)Match(input,49,FOLLOW_49_in_engine_entity1277); 
            		char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:292:22: ( entity_content )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= ENTITY_ENGINE && LA5_0 <= ENTITY_EVENT) || (LA5_0 >= TRIGGER_INIT && LA5_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:292:22: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_engine_entity1279);
            			    	entity_content19 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal20=(IToken)Match(input,50,FOLLOW_50_in_engine_entity1282); 
            		char_literal20_tree = (object)adaptor.Create(char_literal20);
            		adaptor.AddChild(root_0, char_literal20_tree);

            	 retval.en =  new EngineEntity(((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "engine_entity"

    public class player_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "player_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:295:1: player_entity returns [Entity en] : ENTITY_PLAYER name= CLASS_IDENTIFIER '{' ( entity_content )* '}' ;
    public GbsParser.player_entity_return player_entity() // throws RecognitionException [1]
    {   
        GbsParser.player_entity_return retval = new GbsParser.player_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_PLAYER21 = null;
        IToken char_literal22 = null;
        IToken char_literal24 = null;
        GbsParser.entity_content_return entity_content23 = default(GbsParser.entity_content_return);


        object name_tree=null;
        object ENTITY_PLAYER21_tree=null;
        object char_literal22_tree=null;
        object char_literal24_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:296:2: ( ENTITY_PLAYER name= CLASS_IDENTIFIER '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:296:4: ENTITY_PLAYER name= CLASS_IDENTIFIER '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_PLAYER21=(IToken)Match(input,ENTITY_PLAYER,FOLLOW_ENTITY_PLAYER_in_player_entity1300); 
            		ENTITY_PLAYER21_tree = (object)adaptor.Create(ENTITY_PLAYER21);
            		adaptor.AddChild(root_0, ENTITY_PLAYER21_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_entity1304); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal22=(IToken)Match(input,49,FOLLOW_49_in_player_entity1306); 
            		char_literal22_tree = (object)adaptor.Create(char_literal22);
            		adaptor.AddChild(root_0, char_literal22_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:296:44: ( entity_content )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= ENTITY_ENGINE && LA6_0 <= ENTITY_EVENT) || (LA6_0 >= TRIGGER_INIT && LA6_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:296:44: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_player_entity1308);
            			    	entity_content23 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content23.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal24=(IToken)Match(input,50,FOLLOW_50_in_player_entity1311); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

            	 retval.en =  new PlayerEntity(name.Text, ((entity_scope)entity_stack.Peek()).subEntities, ((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "player_entity"

    public class enemy_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "enemy_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:299:1: enemy_entity returns [Entity en] : ENTITY_ENEMY name= CLASS_IDENTIFIER '{' ( entity_content )* '}' ;
    public GbsParser.enemy_entity_return enemy_entity() // throws RecognitionException [1]
    {   
        GbsParser.enemy_entity_return retval = new GbsParser.enemy_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_ENEMY25 = null;
        IToken char_literal26 = null;
        IToken char_literal28 = null;
        GbsParser.entity_content_return entity_content27 = default(GbsParser.entity_content_return);


        object name_tree=null;
        object ENTITY_ENEMY25_tree=null;
        object char_literal26_tree=null;
        object char_literal28_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:300:2: ( ENTITY_ENEMY name= CLASS_IDENTIFIER '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:300:4: ENTITY_ENEMY name= CLASS_IDENTIFIER '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_ENEMY25=(IToken)Match(input,ENTITY_ENEMY,FOLLOW_ENTITY_ENEMY_in_enemy_entity1328); 
            		ENTITY_ENEMY25_tree = (object)adaptor.Create(ENTITY_ENEMY25);
            		adaptor.AddChild(root_0, ENTITY_ENEMY25_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_entity1332); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal26=(IToken)Match(input,49,FOLLOW_49_in_enemy_entity1334); 
            		char_literal26_tree = (object)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:300:43: ( entity_content )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= ENTITY_ENGINE && LA7_0 <= ENTITY_EVENT) || (LA7_0 >= TRIGGER_INIT && LA7_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:300:43: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_enemy_entity1336);
            			    	entity_content27 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content27.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal28=(IToken)Match(input,50,FOLLOW_50_in_enemy_entity1339); 
            		char_literal28_tree = (object)adaptor.Create(char_literal28);
            		adaptor.AddChild(root_0, char_literal28_tree);

            	 retval.en =  new EnemyEntity(name.Text, ((entity_scope)entity_stack.Peek()).subEntities, ((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "enemy_entity"

    public class bullet_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bullet_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:303:1: bullet_entity returns [Entity en] : ENTITY_BULLET name= CLASS_IDENTIFIER '{' ( entity_content )* '}' ;
    public GbsParser.bullet_entity_return bullet_entity() // throws RecognitionException [1]
    {   
        GbsParser.bullet_entity_return retval = new GbsParser.bullet_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_BULLET29 = null;
        IToken char_literal30 = null;
        IToken char_literal32 = null;
        GbsParser.entity_content_return entity_content31 = default(GbsParser.entity_content_return);


        object name_tree=null;
        object ENTITY_BULLET29_tree=null;
        object char_literal30_tree=null;
        object char_literal32_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:304:2: ( ENTITY_BULLET name= CLASS_IDENTIFIER '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:304:4: ENTITY_BULLET name= CLASS_IDENTIFIER '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_BULLET29=(IToken)Match(input,ENTITY_BULLET,FOLLOW_ENTITY_BULLET_in_bullet_entity1356); 
            		ENTITY_BULLET29_tree = (object)adaptor.Create(ENTITY_BULLET29);
            		adaptor.AddChild(root_0, ENTITY_BULLET29_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_entity1360); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal30=(IToken)Match(input,49,FOLLOW_49_in_bullet_entity1362); 
            		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		adaptor.AddChild(root_0, char_literal30_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:304:44: ( entity_content )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= ENTITY_ENGINE && LA8_0 <= ENTITY_EVENT) || (LA8_0 >= TRIGGER_INIT && LA8_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:304:44: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_bullet_entity1364);
            			    	entity_content31 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content31.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal32=(IToken)Match(input,50,FOLLOW_50_in_bullet_entity1367); 
            		char_literal32_tree = (object)adaptor.Create(char_literal32);
            		adaptor.AddChild(root_0, char_literal32_tree);

            	 retval.en =  new BulletEntity(name.Text, ((entity_scope)entity_stack.Peek()).subEntities, ((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "bullet_entity"

    public class script_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "script_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:307:1: script_entity returns [Entity en] : ENTITY_SCRIPT name= CLASS_IDENTIFIER '{' ( entity_content )* '}' ;
    public GbsParser.script_entity_return script_entity() // throws RecognitionException [1]
    {   
        GbsParser.script_entity_return retval = new GbsParser.script_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_SCRIPT33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        GbsParser.entity_content_return entity_content35 = default(GbsParser.entity_content_return);


        object name_tree=null;
        object ENTITY_SCRIPT33_tree=null;
        object char_literal34_tree=null;
        object char_literal36_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:308:2: ( ENTITY_SCRIPT name= CLASS_IDENTIFIER '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:308:4: ENTITY_SCRIPT name= CLASS_IDENTIFIER '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_SCRIPT33=(IToken)Match(input,ENTITY_SCRIPT,FOLLOW_ENTITY_SCRIPT_in_script_entity1385); 
            		ENTITY_SCRIPT33_tree = (object)adaptor.Create(ENTITY_SCRIPT33);
            		adaptor.AddChild(root_0, ENTITY_SCRIPT33_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_entity1389); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal34=(IToken)Match(input,49,FOLLOW_49_in_script_entity1391); 
            		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:308:44: ( entity_content )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= ENTITY_ENGINE && LA9_0 <= ENTITY_EVENT) || (LA9_0 >= TRIGGER_INIT && LA9_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:308:44: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_script_entity1393);
            			    	entity_content35 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content35.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	char_literal36=(IToken)Match(input,50,FOLLOW_50_in_script_entity1396); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

            	 retval.en =  new ScriptEntity(name.Text, ((entity_scope)entity_stack.Peek()).subEntities, ((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "script_entity"

    public class state_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "state_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:311:1: state_entity returns [Entity en] : ENTITY_STATE name= CLASS_IDENTIFIER '{' ( entity_content )* '}' ;
    public GbsParser.state_entity_return state_entity() // throws RecognitionException [1]
    {   
        GbsParser.state_entity_return retval = new GbsParser.state_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_STATE37 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        GbsParser.entity_content_return entity_content39 = default(GbsParser.entity_content_return);


        object name_tree=null;
        object ENTITY_STATE37_tree=null;
        object char_literal38_tree=null;
        object char_literal40_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:312:2: ( ENTITY_STATE name= CLASS_IDENTIFIER '{' ( entity_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:312:4: ENTITY_STATE name= CLASS_IDENTIFIER '{' ( entity_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_STATE37=(IToken)Match(input,ENTITY_STATE,FOLLOW_ENTITY_STATE_in_state_entity1413); 
            		ENTITY_STATE37_tree = (object)adaptor.Create(ENTITY_STATE37);
            		adaptor.AddChild(root_0, ENTITY_STATE37_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_entity1417); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal38=(IToken)Match(input,49,FOLLOW_49_in_state_entity1419); 
            		char_literal38_tree = (object)adaptor.Create(char_literal38);
            		adaptor.AddChild(root_0, char_literal38_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:312:43: ( entity_content )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= ENTITY_ENGINE && LA10_0 <= ENTITY_EVENT) || (LA10_0 >= TRIGGER_INIT && LA10_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:312:43: entity_content
            			    {
            			    	PushFollow(FOLLOW_entity_content_in_state_entity1421);
            			    	entity_content39 = entity_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity_content39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal40=(IToken)Match(input,50,FOLLOW_50_in_state_entity1424); 
            		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		adaptor.AddChild(root_0, char_literal40_tree);

            	 retval.en =  new StateEntity(name.Text, ((entity_scope)entity_stack.Peek()).subEntities, ((entity_scope)entity_stack.Peek()).triggers); 

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
    // $ANTLR end "state_entity"

    public class event_entity_return : ParserRuleReturnScope
    {
        public Entity en;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "event_entity"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:315:1: event_entity returns [Entity en] : ENTITY_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_entity_return event_entity() // throws RecognitionException [1]
    {   
        GbsParser.event_entity_return retval = new GbsParser.event_entity_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken ENTITY_EVENT41 = null;

        object name_tree=null;
        object ENTITY_EVENT41_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:316:2: ( ENTITY_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:316:4: ENTITY_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENTITY_EVENT41=(IToken)Match(input,ENTITY_EVENT,FOLLOW_ENTITY_EVENT_in_event_entity1443); 
            		ENTITY_EVENT41_tree = (object)adaptor.Create(ENTITY_EVENT41);
            		adaptor.AddChild(root_0, ENTITY_EVENT41_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_entity1447); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	 retval.en =  new EventEntity(name.Text); 

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
    // $ANTLR end "event_entity"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:319:1: action_list returns [List<Action> actions] : ( action )* ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:328:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:328:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:328:4: ( action )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == THIS || (LA11_0 >= PARAM_FPS && LA11_0 <= ACTION_SET) || LA11_0 == INSTANCE_IDENTIFIER) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:328:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1476);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:331:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:332:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == THIS || (LA13_0 >= ACTION_PERIODIC && LA13_0 <= ACTION_SET)) )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:332:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:332:4: ( THIS )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == THIS) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:332:4: THIS
                    	        {
                    	        	THIS43=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target1494); 
                    	        		THIS43_tree = (object)adaptor.Create(THIS43);
                    	        		adaptor.AddChild(root_0, THIS43_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:333:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target1524); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:336:1: action : (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action );
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



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:337:2: (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action )
            int alt14 = 8;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:337:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action1539);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:338:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action1548);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:339:4: fap= fireAtPlayer_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fireAtPlayer_action_in_action1564);
                    	fap = fireAtPlayer_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:340:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action1575);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:341:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action1596);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:342:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action1614);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:343:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action1634);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:344:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action1651);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:347:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:348:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:348:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action1682);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION44=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1684); 
            		ACTION_PLAY_ANIMATION44_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION44);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION44_tree);

            	char_literal45=(IToken)Match(input,51,FOLLOW_51_in_play_animation_action1686); 
            		char_literal45_tree = (object)adaptor.Create(char_literal45);
            		adaptor.AddChild(root_0, char_literal45_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action1690); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal46=(IToken)Match(input,52,FOLLOW_52_in_play_animation_action1692); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:351:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_PERIODIC47 = null;
        IToken char_literal48 = null;
        IToken NUMBER49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object ACTION_PERIODIC47_tree=null;
        object char_literal48_tree=null;
        object NUMBER49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:352:2: (target= action_target ACTION_PERIODIC '(' NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:352:4: target= action_target ACTION_PERIODIC '(' NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action1712);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC47=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action1714); 
            		ACTION_PERIODIC47_tree = (object)adaptor.Create(ACTION_PERIODIC47);
            		adaptor.AddChild(root_0, ACTION_PERIODIC47_tree);

            	char_literal48=(IToken)Match(input,51,FOLLOW_51_in_periodic_action1716); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

            	NUMBER49=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action1718); 
            		NUMBER49_tree = (object)adaptor.Create(NUMBER49);
            		adaptor.AddChild(root_0, NUMBER49_tree);

            	char_literal50=(IToken)Match(input,52,FOLLOW_52_in_periodic_action1720); 
            		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		adaptor.AddChild(root_0, char_literal50_tree);

            	char_literal51=(IToken)Match(input,49,FOLLOW_49_in_periodic_action1722); 
            		char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action1726);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal52=(IToken)Match(input,50,FOLLOW_50_in_periodic_action1728); 
            		char_literal52_tree = (object)adaptor.Create(char_literal52);
            		adaptor.AddChild(root_0, char_literal52_tree);

            	 retval.action =  new PeriodicAction(((target != null) ? target.target : default(String)), ((actions != null) ? actions.actions : default(List<Action>))); 

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:355:1: fireAtPlayer_action returns [Action action] : target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')' ;
    public GbsParser.fireAtPlayer_action_return fireAtPlayer_action() // throws RecognitionException [1]
    {   
        GbsParser.fireAtPlayer_action_return retval = new GbsParser.fireAtPlayer_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE_AT_PLAYER53 = null;
        IToken char_literal54 = null;
        IToken char_literal55 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object bullet_tree=null;
        object ACTION_FIRE_AT_PLAYER53_tree=null;
        object char_literal54_tree=null;
        object char_literal55_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:356:2: (target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:356:4: target= action_target ACTION_FIRE_AT_PLAYER '(' bullet= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fireAtPlayer_action1748);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE_AT_PLAYER53=(IToken)Match(input,ACTION_FIRE_AT_PLAYER,FOLLOW_ACTION_FIRE_AT_PLAYER_in_fireAtPlayer_action1750); 
            		ACTION_FIRE_AT_PLAYER53_tree = (object)adaptor.Create(ACTION_FIRE_AT_PLAYER53);
            		adaptor.AddChild(root_0, ACTION_FIRE_AT_PLAYER53_tree);

            	char_literal54=(IToken)Match(input,51,FOLLOW_51_in_fireAtPlayer_action1752); 
            		char_literal54_tree = (object)adaptor.Create(char_literal54);
            		adaptor.AddChild(root_0, char_literal54_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fireAtPlayer_action1756); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal55=(IToken)Match(input,52,FOLLOW_52_in_fireAtPlayer_action1758); 
            		char_literal55_tree = (object)adaptor.Create(char_literal55);
            		adaptor.AddChild(root_0, char_literal55_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:359:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE56 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE56_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:360:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:360:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action1778);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE56=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action1780); 
            		ACTION_DIE56_tree = (object)adaptor.Create(ACTION_DIE56);
            		adaptor.AddChild(root_0, ACTION_DIE56_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:363:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START57 = null;
        IToken char_literal58 = null;
        IToken char_literal59 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START57_tree=null;
        object char_literal58_tree=null;
        object char_literal59_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:364:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:364:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action1800);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START57=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action1802); 
            		ACTION_START57_tree = (object)adaptor.Create(ACTION_START57);
            		adaptor.AddChild(root_0, ACTION_START57_tree);

            	char_literal58=(IToken)Match(input,51,FOLLOW_51_in_start_action1804); 
            		char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action1808); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal59=(IToken)Match(input,52,FOLLOW_52_in_start_action1810); 
            		char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:367:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP60 = null;
        IToken char_literal61 = null;
        IToken char_literal62 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP60_tree=null;
        object char_literal61_tree=null;
        object char_literal62_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:368:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:368:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action1829);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP60=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action1831); 
            		ACTION_STOP60_tree = (object)adaptor.Create(ACTION_STOP60);
            		adaptor.AddChild(root_0, ACTION_STOP60_tree);

            	char_literal61=(IToken)Match(input,51,FOLLOW_51_in_stop_action1833); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action1837); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal62=(IToken)Match(input,52,FOLLOW_52_in_stop_action1839); 
            		char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:371:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON63 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON63_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:372:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:372:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action1860);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON63=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action1862); 
            		ACTION_SUMMON63_tree = (object)adaptor.Create(ACTION_SUMMON63);
            		adaptor.AddChild(root_0, ACTION_SUMMON63_tree);

            	char_literal64=(IToken)Match(input,51,FOLLOW_51_in_summon_action1864); 
            		char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action1868); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal65=(IToken)Match(input,52,FOLLOW_52_in_summon_action1870); 
            		char_literal65_tree = (object)adaptor.Create(char_literal65);
            		adaptor.AddChild(root_0, char_literal65_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action1874); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:372:95: ( '{' a= action_list '}' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 49) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:372:97: '{' a= action_list '}'
            	        {
            	        	char_literal66=(IToken)Match(input,49,FOLLOW_49_in_summon_action1878); 
            	        		char_literal66_tree = (object)adaptor.Create(char_literal66);
            	        		adaptor.AddChild(root_0, char_literal66_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action1882);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal67=(IToken)Match(input,50,FOLLOW_50_in_summon_action1884); 
            	        		char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        		adaptor.AddChild(root_0, char_literal67_tree);


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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:375:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET68 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET68_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:376:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == THIS || (LA16_0 >= ACTION_PERIODIC && LA16_0 <= ACTION_SET) || LA16_0 == INSTANCE_IDENTIFIER) )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:376:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action1907);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET68=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action1909); 
                    		ACTION_SET68_tree = (object)adaptor.Create(ACTION_SET68);
                    		adaptor.AddChild(root_0, ACTION_SET68_tree);

                    	char_literal69=(IToken)Match(input,51,FOLLOW_51_in_set_action1911); 
                    		char_literal69_tree = (object)adaptor.Create(char_literal69);
                    		adaptor.AddChild(root_0, char_literal69_tree);

                    	PushFollow(FOLLOW_param_in_set_action1915);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal70=(IToken)Match(input,52,FOLLOW_52_in_set_action1917); 
                    		char_literal70_tree = (object)adaptor.Create(char_literal70);
                    		adaptor.AddChild(root_0, char_literal70_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:377:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action1926);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:380:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
    public GbsParser.trigger_return trigger() // throws RecognitionException [1]
    {   
        GbsParser.trigger_return retval = new GbsParser.trigger_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken time = null;
        IToken scroll = null;
        IToken anim = null;
        IToken e = null;
        IToken TRIGGER_INIT71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken TRIGGER_CLEANUP74 = null;
        IToken char_literal75 = null;
        IToken char_literal76 = null;
        IToken TRIGGER_TIME77 = null;
        IToken char_literal78 = null;
        IToken char_literal79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken TRIGGER_SCROLLING82 = null;
        IToken char_literal83 = null;
        IToken char_literal84 = null;
        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken TRIGGER_ANIMATION_END87 = null;
        IToken char_literal88 = null;
        IToken char_literal89 = null;
        IToken char_literal90 = null;
        IToken char_literal91 = null;
        IToken TRIGGER_EVENT92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object TRIGGER_CLEANUP74_tree=null;
        object char_literal75_tree=null;
        object char_literal76_tree=null;
        object TRIGGER_TIME77_tree=null;
        object char_literal78_tree=null;
        object char_literal79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object TRIGGER_SCROLLING82_tree=null;
        object char_literal83_tree=null;
        object char_literal84_tree=null;
        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object TRIGGER_ANIMATION_END87_tree=null;
        object char_literal88_tree=null;
        object char_literal89_tree=null;
        object char_literal90_tree=null;
        object char_literal91_tree=null;
        object TRIGGER_EVENT92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:381:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
            int alt17 = 6;
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
            case TRIGGER_SCROLLING:
            	{
                alt17 = 4;
                }
                break;
            case TRIGGER_ANIMATION_END:
            	{
                alt17 = 5;
                }
                break;
            case TRIGGER_EVENT:
            	{
                alt17 = 6;
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:381:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT71=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger1984); 
                    		TRIGGER_INIT71_tree = (object)adaptor.Create(TRIGGER_INIT71);
                    		adaptor.AddChild(root_0, TRIGGER_INIT71_tree);

                    	char_literal72=(IToken)Match(input,49,FOLLOW_49_in_trigger1986); 
                    		char_literal72_tree = (object)adaptor.Create(char_literal72);
                    		adaptor.AddChild(root_0, char_literal72_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger1990);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal73=(IToken)Match(input,50,FOLLOW_50_in_trigger1992); 
                    		char_literal73_tree = (object)adaptor.Create(char_literal73);
                    		adaptor.AddChild(root_0, char_literal73_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:382:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP74=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2028); 
                    		TRIGGER_CLEANUP74_tree = (object)adaptor.Create(TRIGGER_CLEANUP74);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP74_tree);

                    	char_literal75=(IToken)Match(input,49,FOLLOW_49_in_trigger2030); 
                    		char_literal75_tree = (object)adaptor.Create(char_literal75);
                    		adaptor.AddChild(root_0, char_literal75_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2034);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal76=(IToken)Match(input,50,FOLLOW_50_in_trigger2036); 
                    		char_literal76_tree = (object)adaptor.Create(char_literal76);
                    		adaptor.AddChild(root_0, char_literal76_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:383:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME77=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2069); 
                    		TRIGGER_TIME77_tree = (object)adaptor.Create(TRIGGER_TIME77);
                    		adaptor.AddChild(root_0, TRIGGER_TIME77_tree);

                    	char_literal78=(IToken)Match(input,51,FOLLOW_51_in_trigger2071); 
                    		char_literal78_tree = (object)adaptor.Create(char_literal78);
                    		adaptor.AddChild(root_0, char_literal78_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2075); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal79=(IToken)Match(input,52,FOLLOW_52_in_trigger2077); 
                    		char_literal79_tree = (object)adaptor.Create(char_literal79);
                    		adaptor.AddChild(root_0, char_literal79_tree);

                    	char_literal80=(IToken)Match(input,49,FOLLOW_49_in_trigger2079); 
                    		char_literal80_tree = (object)adaptor.Create(char_literal80);
                    		adaptor.AddChild(root_0, char_literal80_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2083);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal81=(IToken)Match(input,50,FOLLOW_50_in_trigger2085); 
                    		char_literal81_tree = (object)adaptor.Create(char_literal81);
                    		adaptor.AddChild(root_0, char_literal81_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:384:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING82=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2101); 
                    		TRIGGER_SCROLLING82_tree = (object)adaptor.Create(TRIGGER_SCROLLING82);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING82_tree);

                    	char_literal83=(IToken)Match(input,51,FOLLOW_51_in_trigger2103); 
                    		char_literal83_tree = (object)adaptor.Create(char_literal83);
                    		adaptor.AddChild(root_0, char_literal83_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2107); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal84=(IToken)Match(input,52,FOLLOW_52_in_trigger2109); 
                    		char_literal84_tree = (object)adaptor.Create(char_literal84);
                    		adaptor.AddChild(root_0, char_literal84_tree);

                    	char_literal85=(IToken)Match(input,49,FOLLOW_49_in_trigger2111); 
                    		char_literal85_tree = (object)adaptor.Create(char_literal85);
                    		adaptor.AddChild(root_0, char_literal85_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2115);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal86=(IToken)Match(input,50,FOLLOW_50_in_trigger2117); 
                    		char_literal86_tree = (object)adaptor.Create(char_literal86);
                    		adaptor.AddChild(root_0, char_literal86_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:385:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END87=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2126); 
                    		TRIGGER_ANIMATION_END87_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END87);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END87_tree);

                    	char_literal88=(IToken)Match(input,51,FOLLOW_51_in_trigger2128); 
                    		char_literal88_tree = (object)adaptor.Create(char_literal88);
                    		adaptor.AddChild(root_0, char_literal88_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2132); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal89=(IToken)Match(input,52,FOLLOW_52_in_trigger2134); 
                    		char_literal89_tree = (object)adaptor.Create(char_literal89);
                    		adaptor.AddChild(root_0, char_literal89_tree);

                    	char_literal90=(IToken)Match(input,49,FOLLOW_49_in_trigger2136); 
                    		char_literal90_tree = (object)adaptor.Create(char_literal90);
                    		adaptor.AddChild(root_0, char_literal90_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2140);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal91=(IToken)Match(input,50,FOLLOW_50_in_trigger2142); 
                    		char_literal91_tree = (object)adaptor.Create(char_literal91);
                    		adaptor.AddChild(root_0, char_literal91_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Compiler\\Gbs.g:386:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT92=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2149); 
                    		TRIGGER_EVENT92_tree = (object)adaptor.Create(TRIGGER_EVENT92);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT92_tree);

                    	char_literal93=(IToken)Match(input,51,FOLLOW_51_in_trigger2151); 
                    		char_literal93_tree = (object)adaptor.Create(char_literal93);
                    		adaptor.AddChild(root_0, char_literal93_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2155); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal94=(IToken)Match(input,52,FOLLOW_52_in_trigger2157); 
                    		char_literal94_tree = (object)adaptor.Create(char_literal94);
                    		adaptor.AddChild(root_0, char_literal94_tree);

                    	char_literal95=(IToken)Match(input,49,FOLLOW_49_in_trigger2159); 
                    		char_literal95_tree = (object)adaptor.Create(char_literal95);
                    		adaptor.AddChild(root_0, char_literal95_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2163);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal96=(IToken)Match(input,50,FOLLOW_50_in_trigger2165); 
                    		char_literal96_tree = (object)adaptor.Create(char_literal96);
                    		adaptor.AddChild(root_0, char_literal96_tree);

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
        "\x0b\uffff";
    const string DFA14_eofS =
        "\x0b\uffff";
    const string DFA14_minS =
        "\x01\x04\x01\x13\x01\uffff\x01\x13\x07\uffff";
    const string DFA14_maxS =
        "\x01\x2a\x01\x1a\x01\uffff\x01\x1a\x07\uffff";
    const string DFA14_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08";
    const string DFA14_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x01\x07\uffff\x07\x0a\x01\x04\x01\x05\x01\x06\x01\x07"+
            "\x01\x08\x01\x09\x01\x02\x01\x0a\x0f\uffff\x01\x03",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x02\x01"+
            "\x0a",
            "",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x02\x01"+
            "\x0a",
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
            get { return "336:1: action : (pla= play_animation_action | pa= periodic_action | fap= fireAtPlayer_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_entity_in_gbs867 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_fps_param_in_param887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param903 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param979 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_fps_param981 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1002 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_gamearea_param1004 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1026 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_position_param1028 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1050 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_speed_param1052 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1074 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_animation_param1076 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1098 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_color_param1100 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1122 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_scrolling_param1124 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1128 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_scrolling_param1130 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_entity_in_entity1165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_entity_in_entity1174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_entity_in_entity1183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_entity_in_entity1192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_entity_in_entity1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_entity_in_entity1210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_entity_in_entity1219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_entity_content1234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_entity_in_entity_content1250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_ENGINE_in_engine_entity1275 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_engine_entity1277 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_engine_entity1279 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_engine_entity1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_PLAYER_in_player_entity1300 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_entity1304 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_player_entity1306 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_player_entity1308 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_player_entity1311 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_ENEMY_in_enemy_entity1328 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_entity1332 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_enemy_entity1334 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_enemy_entity1336 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_enemy_entity1339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_BULLET_in_bullet_entity1356 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_entity1360 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_bullet_entity1362 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_bullet_entity1364 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_bullet_entity1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_SCRIPT_in_script_entity1385 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_entity1389 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_script_entity1391 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_script_entity1393 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_script_entity1396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_STATE_in_state_entity1413 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_entity1417 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_state_entity1419 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_entity_content_in_state_entity1421 = new BitSet(new ulong[]{0x00040001F8000FE0UL});
    public static readonly BitSet FOLLOW_50_in_state_entity1424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENTITY_EVENT_in_event_entity1443 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_entity1447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1476 = new BitSet(new ulong[]{0x0000040007FFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target1494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target1524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action1548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fireAtPlayer_action_in_action1564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action1575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action1596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action1614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action1634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action1651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action1682 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1684 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_play_animation_action1686 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action1690 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_play_animation_action1692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action1712 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action1714 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_periodic_action1716 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action1718 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_periodic_action1720 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_periodic_action1722 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action1726 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_periodic_action1728 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fireAtPlayer_action1748 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_AT_PLAYER_in_fireAtPlayer_action1750 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_fireAtPlayer_action1752 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fireAtPlayer_action1756 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_fireAtPlayer_action1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action1778 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action1780 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action1800 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action1802 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_start_action1804 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action1808 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_start_action1810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action1829 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action1831 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_stop_action1833 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action1837 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_stop_action1839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action1860 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action1862 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_summon_action1864 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action1868 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_summon_action1870 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action1874 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_summon_action1878 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action1882 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_summon_action1884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action1907 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action1909 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_set_action1911 = new BitSet(new ulong[]{0x0010040007FFF010UL});
    public static readonly BitSet FOLLOW_param_in_set_action1915 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_set_action1917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action1926 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger1984 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger1986 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger1990 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger1992 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2028 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger2030 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2034 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger2036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2069 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2071 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2075 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2077 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger2079 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2083 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger2085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2101 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2103 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2107 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2109 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger2111 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2115 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger2117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2126 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2128 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2132 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2134 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger2136 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2140 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger2142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2149 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_trigger2151 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2155 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_trigger2157 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_trigger2159 = new BitSet(new ulong[]{0x0000040007FFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2163 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_trigger2165 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}