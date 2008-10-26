// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-10-26 22:22:49
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
		"'+'", 
		"'-'", 
		"'*'", 
		"'°'", 
		"'..'", 
		"'('", 
		"')'", 
		"'='", 
		"','", 
		"'{'", 
		"'}'"
    };

    public const int DIRECTION = 44;
    public const int T__64 = 64;
    public const int CONST_ANGLE_RIGHT = 39;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int ACTION_SET = 26;
    public const int POINT = 46;
    public const int TRIGGER_SCROLLING = 32;
    public const int CLASSDEF_SCRIPT = 9;
    public const int CONST_ANGLE_UP = 37;
    public const int T__61 = 61;
    public const int T__60 = 60;
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
    public const int CONST_ANGLE_DOWN = 36;
    public const int TRIGGER_INIT = 28;
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:246:1: gbs returns [Gbs s] : ( classdef )* ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:2: ( ( classdef )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:4: ( classdef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:4: ( classdef )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:255:4: classdef
            			    {
            			    	PushFollow(FOLLOW_classdef_in_gbs949);
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

    protected class formula_scope 
    {
        protected internal List<bool> add;
        protected internal List<Formula> terms;
    }
    protected Stack formula_stack = new Stack();

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:258:1: formula returns [Formula formula] : a= factor_formula ( '+' b= factor_formula | '-' b= factor_formula )* ;
    public GbsParser.formula_return formula() // throws RecognitionException [1]
    {   
        formula_stack.Push(new formula_scope());
        GbsParser.formula_return retval = new GbsParser.formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal2 = null;
        IToken char_literal3 = null;
        GbsParser.factor_formula_return a = default(GbsParser.factor_formula_return);

        GbsParser.factor_formula_return b = default(GbsParser.factor_formula_return);


        object char_literal2_tree=null;
        object char_literal3_tree=null;

         
        	retval.formula::add = new List<bool>();
        	retval.formula::terms = new List<Formula>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:2: (a= factor_formula ( '+' b= factor_formula | '-' b= factor_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:4: a= factor_formula ( '+' b= factor_formula | '-' b= factor_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_factor_formula_in_formula981);
            	a = factor_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:21: ( '+' b= factor_formula | '-' b= factor_formula )*
            	do 
            	{
            	    int alt2 = 3;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 54) )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == 55) )
            	    {
            	        alt2 = 2;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:23: '+' b= factor_formula
            			    {
            			    	char_literal2=(IToken)Match(input,54,FOLLOW_54_in_formula985); 
            			    		char_literal2_tree = (object)adaptor.Create(char_literal2);
            			    		adaptor.AddChild(root_0, char_literal2_tree);

            			    	PushFollow(FOLLOW_factor_formula_in_formula989);
            			    	b = factor_formula();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, b.Tree);
            			    	 retval.formula::add.Add(true); retval.formula::terms.Add(((b != null) ? b.formula : default(Formula))); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:269:108: '-' b= factor_formula
            			    {
            			    	char_literal3=(IToken)Match(input,55,FOLLOW_55_in_formula995); 
            			    		char_literal3_tree = (object)adaptor.Create(char_literal3);
            			    		adaptor.AddChild(root_0, char_literal3_tree);

            			    	PushFollow(FOLLOW_factor_formula_in_formula999);
            			    	b = factor_formula();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, b.Tree);
            			    	 retval.formula::add.Add(false); retval.formula::terms.Add(((b != null) ? b.formula : default(Formula))); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	 retval.formula =  new RawSumFormula(((a != null) ? a.formula : default(Formula)), retval.formula::add, retval.formula::terms); 

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
            formula_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "formula"

    public class factor_formula_return : ParserRuleReturnScope
    {
        public Formula formula;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "factor_formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:272:1: factor_formula returns [Formula formula] : a= simple_formula ( '*' b= simple_formula )* ;
    public GbsParser.factor_formula_return factor_formula() // throws RecognitionException [1]
    {   
        GbsParser.factor_formula_return retval = new GbsParser.factor_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal4 = null;
        GbsParser.simple_formula_return a = default(GbsParser.simple_formula_return);

        GbsParser.simple_formula_return b = default(GbsParser.simple_formula_return);


        object char_literal4_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:273:2: (a= simple_formula ( '*' b= simple_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:273:4: a= simple_formula ( '*' b= simple_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_simple_formula_in_factor_formula1024);
            	a = simple_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:273:21: ( '*' b= simple_formula )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 56) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:273:23: '*' b= simple_formula
            			    {
            			    	char_literal4=(IToken)Match(input,56,FOLLOW_56_in_factor_formula1028); 
            			    		char_literal4_tree = (object)adaptor.Create(char_literal4);
            			    		adaptor.AddChild(root_0, char_literal4_tree);

            			    	PushFollow(FOLLOW_simple_formula_in_factor_formula1032);
            			    	b = simple_formula();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, b.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // $ANTLR end "factor_formula"

    public class simple_formula_return : ParserRuleReturnScope
    {
        public Formula formula;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simple_formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:276:1: simple_formula returns [Formula formula] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | a= NUMBER '..' b= NUMBER | '(' f= formula ')' );
    public GbsParser.simple_formula_return simple_formula() // throws RecognitionException [1]
    {   
        GbsParser.simple_formula_return retval = new GbsParser.simple_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken c = null;
        IToken a = null;
        IToken b = null;
        IToken char_literal5 = null;
        IToken CONST_ANGLE_DOWN6 = null;
        IToken CONST_ANGLE_UP7 = null;
        IToken CONST_ANGLE_LEFT8 = null;
        IToken CONST_ANGLE_RIGHT9 = null;
        IToken PREDEF_ANGLE_TOWARD_PLAYER10 = null;
        IToken string_literal11 = null;
        IToken char_literal12 = null;
        IToken char_literal13 = null;
        GbsParser.formula_return f = default(GbsParser.formula_return);


        object c_tree=null;
        object a_tree=null;
        object b_tree=null;
        object char_literal5_tree=null;
        object CONST_ANGLE_DOWN6_tree=null;
        object CONST_ANGLE_UP7_tree=null;
        object CONST_ANGLE_LEFT8_tree=null;
        object CONST_ANGLE_RIGHT9_tree=null;
        object PREDEF_ANGLE_TOWARD_PLAYER10_tree=null;
        object string_literal11_tree=null;
        object char_literal12_tree=null;
        object char_literal13_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:2: (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | a= NUMBER '..' b= NUMBER | '(' f= formula ')' )
            int alt4 = 9;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:4: c= NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1053); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	 retval.formula =  new ConstValueFormula(float.Parse(c.Text)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:278:4: c= NUMBER '°'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1062); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	char_literal5=(IToken)Match(input,57,FOLLOW_57_in_simple_formula1064); 
                    		char_literal5_tree = (object)adaptor.Create(char_literal5);
                    		adaptor.AddChild(root_0, char_literal5_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.DegreeToRadian(float.Parse(c.Text))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:279:4: CONST_ANGLE_DOWN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_DOWN6=(IToken)Match(input,CONST_ANGLE_DOWN,FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1071); 
                    		CONST_ANGLE_DOWN6_tree = (object)adaptor.Create(CONST_ANGLE_DOWN6);
                    		adaptor.AddChild(root_0, CONST_ANGLE_DOWN6_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_DOWN); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:280:4: CONST_ANGLE_UP
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_UP7=(IToken)Match(input,CONST_ANGLE_UP,FOLLOW_CONST_ANGLE_UP_in_simple_formula1078); 
                    		CONST_ANGLE_UP7_tree = (object)adaptor.Create(CONST_ANGLE_UP7);
                    		adaptor.AddChild(root_0, CONST_ANGLE_UP7_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_UP); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:281:4: CONST_ANGLE_LEFT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_LEFT8=(IToken)Match(input,CONST_ANGLE_LEFT,FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1085); 
                    		CONST_ANGLE_LEFT8_tree = (object)adaptor.Create(CONST_ANGLE_LEFT8);
                    		adaptor.AddChild(root_0, CONST_ANGLE_LEFT8_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_LEFT); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:282:4: CONST_ANGLE_RIGHT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_RIGHT9=(IToken)Match(input,CONST_ANGLE_RIGHT,FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1092); 
                    		CONST_ANGLE_RIGHT9_tree = (object)adaptor.Create(CONST_ANGLE_RIGHT9);
                    		adaptor.AddChild(root_0, CONST_ANGLE_RIGHT9_tree);

                    	 retval.formula =  new ConstValueFormula(MathHelper.ANGLE_RIGHT); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:283:4: PREDEF_ANGLE_TOWARD_PLAYER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_TOWARD_PLAYER10=(IToken)Match(input,PREDEF_ANGLE_TOWARD_PLAYER,FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1099); 
                    		PREDEF_ANGLE_TOWARD_PLAYER10_tree = (object)adaptor.Create(PREDEF_ANGLE_TOWARD_PLAYER10);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_TOWARD_PLAYER10_tree);

                    	 retval.formula =  new AngleTowardPlayerFormula(); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:284:4: a= NUMBER '..' b= NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	a=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1108); 
                    		a_tree = (object)adaptor.Create(a);
                    		adaptor.AddChild(root_0, a_tree);

                    	string_literal11=(IToken)Match(input,58,FOLLOW_58_in_simple_formula1110); 
                    		string_literal11_tree = (object)adaptor.Create(string_literal11);
                    		adaptor.AddChild(root_0, string_literal11_tree);

                    	b=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1114); 
                    		b_tree = (object)adaptor.Create(b);
                    		adaptor.AddChild(root_0, b_tree);

                    	 retval.formula =  new RangeFormula(float.Parse(a.Text), float.Parse(b.Text)); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:285:4: '(' f= formula ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal12=(IToken)Match(input,59,FOLLOW_59_in_simple_formula1121); 
                    		char_literal12_tree = (object)adaptor.Create(char_literal12);
                    		adaptor.AddChild(root_0, char_literal12_tree);

                    	PushFollow(FOLLOW_formula_in_simple_formula1125);
                    	f = formula();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, f.Tree);
                    	char_literal13=(IToken)Match(input,60,FOLLOW_60_in_simple_formula1127); 
                    		char_literal13_tree = (object)adaptor.Create(char_literal13);
                    		adaptor.AddChild(root_0, char_literal13_tree);

                    	 retval.formula =  ((f != null) ? f.formula : default(Formula)); 

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
    // $ANTLR end "simple_formula"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:288:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:289:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param )
            int alt5 = 7;
            switch ( input.LA(1) ) 
            {
            case PARAM_FPS:
            	{
                alt5 = 1;
                }
                break;
            case PARAM_GAMEAREA:
            	{
                alt5 = 2;
                }
                break;
            case PARAM_POSITION:
            	{
                alt5 = 3;
                }
                break;
            case PARAM_SPEED:
            	{
                alt5 = 4;
                }
                break;
            case PARAM_ANIMATION:
            	{
                alt5 = 5;
                }
                break;
            case PARAM_COLOR:
            	{
                alt5 = 6;
                }
                break;
            case PARAM_SCROLLING:
            	{
                alt5 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:289:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param1147);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:290:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param1163);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param1173);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:292:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param1184);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:293:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param1198);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:294:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param1208);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:295:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param1222);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
    public GbsParser.fps_param_return fps_param() // throws RecognitionException [1]
    {   
        GbsParser.fps_param_return retval = new GbsParser.fps_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken fps = null;
        IToken PARAM_FPS14 = null;
        IToken char_literal15 = null;

        object fps_tree=null;
        object PARAM_FPS14_tree=null;
        object char_literal15_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:299:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:299:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS14=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param1239); 
            		PARAM_FPS14_tree = (object)adaptor.Create(PARAM_FPS14);
            		adaptor.AddChild(root_0, PARAM_FPS14_tree);

            	char_literal15=(IToken)Match(input,61,FOLLOW_61_in_fps_param1241); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param1245); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:302:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
    public GbsParser.gamearea_param_return gamearea_param() // throws RecognitionException [1]
    {   
        GbsParser.gamearea_param_return retval = new GbsParser.gamearea_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken area = null;
        IToken PARAM_GAMEAREA16 = null;
        IToken char_literal17 = null;

        object area_tree=null;
        object PARAM_GAMEAREA16_tree=null;
        object char_literal17_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:303:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:303:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA16=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1262); 
            		PARAM_GAMEAREA16_tree = (object)adaptor.Create(PARAM_GAMEAREA16);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA16_tree);

            	char_literal17=(IToken)Match(input,61,FOLLOW_61_in_gamearea_param1264); 
            		char_literal17_tree = (object)adaptor.Create(char_literal17);
            		adaptor.AddChild(root_0, char_literal17_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1268); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:306:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
    public GbsParser.position_param_return position_param() // throws RecognitionException [1]
    {   
        GbsParser.position_param_return retval = new GbsParser.position_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken pos = null;
        IToken PARAM_POSITION18 = null;
        IToken char_literal19 = null;

        object pos_tree=null;
        object PARAM_POSITION18_tree=null;
        object char_literal19_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:307:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:307:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION18=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1286); 
            		PARAM_POSITION18_tree = (object)adaptor.Create(PARAM_POSITION18);
            		adaptor.AddChild(root_0, PARAM_POSITION18_tree);

            	char_literal19=(IToken)Match(input,61,FOLLOW_61_in_position_param1288); 
            		char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1292); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:310:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
    public GbsParser.speed_param_return speed_param() // throws RecognitionException [1]
    {   
        GbsParser.speed_param_return retval = new GbsParser.speed_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken speed = null;
        IToken PARAM_SPEED20 = null;
        IToken char_literal21 = null;

        object speed_tree=null;
        object PARAM_SPEED20_tree=null;
        object char_literal21_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:311:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:311:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED20=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1310); 
            		PARAM_SPEED20_tree = (object)adaptor.Create(PARAM_SPEED20);
            		adaptor.AddChild(root_0, PARAM_SPEED20_tree);

            	char_literal21=(IToken)Match(input,61,FOLLOW_61_in_speed_param1312); 
            		char_literal21_tree = (object)adaptor.Create(char_literal21);
            		adaptor.AddChild(root_0, char_literal21_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1316); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:314:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
    public GbsParser.animation_param_return animation_param() // throws RecognitionException [1]
    {   
        GbsParser.animation_param_return retval = new GbsParser.animation_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken PARAM_ANIMATION22 = null;
        IToken char_literal23 = null;

        object anim_tree=null;
        object PARAM_ANIMATION22_tree=null;
        object char_literal23_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:315:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:315:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION22=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1334); 
            		PARAM_ANIMATION22_tree = (object)adaptor.Create(PARAM_ANIMATION22);
            		adaptor.AddChild(root_0, PARAM_ANIMATION22_tree);

            	char_literal23=(IToken)Match(input,61,FOLLOW_61_in_animation_param1336); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1340); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:318:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
    public GbsParser.color_param_return color_param() // throws RecognitionException [1]
    {   
        GbsParser.color_param_return retval = new GbsParser.color_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken color = null;
        IToken PARAM_COLOR24 = null;
        IToken char_literal25 = null;

        object color_tree=null;
        object PARAM_COLOR24_tree=null;
        object char_literal25_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:319:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:319:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR24=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1358); 
            		PARAM_COLOR24_tree = (object)adaptor.Create(PARAM_COLOR24);
            		adaptor.AddChild(root_0, PARAM_COLOR24_tree);

            	char_literal25=(IToken)Match(input,61,FOLLOW_61_in_color_param1360); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1364); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:322:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
    public GbsParser.scrolling_param_return scrolling_param() // throws RecognitionException [1]
    {   
        GbsParser.scrolling_param_return retval = new GbsParser.scrolling_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken dir = null;
        IToken speed = null;
        IToken PARAM_SCROLLING26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;

        object dir_tree=null;
        object speed_tree=null;
        object PARAM_SCROLLING26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:323:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:323:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING26=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1382); 
            		PARAM_SCROLLING26_tree = (object)adaptor.Create(PARAM_SCROLLING26);
            		adaptor.AddChild(root_0, PARAM_SCROLLING26_tree);

            	char_literal27=(IToken)Match(input,61,FOLLOW_61_in_scrolling_param1384); 
            		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1388); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal28=(IToken)Match(input,62,FOLLOW_62_in_scrolling_param1390); 
            		char_literal28_tree = (object)adaptor.Create(char_literal28);
            		adaptor.AddChild(root_0, char_literal28_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1394); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:326:1: classdef returns [Classdef en] : (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:337:2: (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef )
            int alt6 = 7;
            switch ( input.LA(1) ) 
            {
            case CLASSDEF_ENGINE:
            	{
                alt6 = 1;
                }
                break;
            case CLASSDEF_PLAYER:
            	{
                alt6 = 2;
                }
                break;
            case CLASSDEF_BULLET:
            	{
                alt6 = 3;
                }
                break;
            case CLASSDEF_ENEMY:
            	{
                alt6 = 4;
                }
                break;
            case CLASSDEF_EVENT:
            	{
                alt6 = 5;
                }
                break;
            case CLASSDEF_STATE:
            	{
                alt6 = 6;
                }
                break;
            case CLASSDEF_SCRIPT:
            	{
                alt6 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:337:4: ee= engine_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_classdef_in_classdef1425);
                    	ee = engine_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:338:4: pe= player_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_classdef_in_classdef1434);
                    	pe = player_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:4: be= bullet_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_classdef_in_classdef1443);
                    	be = bullet_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:4: ene= enemy_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_classdef_in_classdef1452);
                    	ene = enemy_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:341:4: eve= event_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_classdef_in_classdef1461);
                    	eve = event_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:342:4: ste= state_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_classdef_in_classdef1470);
                    	ste = state_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:343:4: se= script_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_classdef_in_classdef1479);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:346:1: classdef_content : (t= trigger | se= classdef );
    public GbsParser.classdef_content_return classdef_content() // throws RecognitionException [1]
    {   
        GbsParser.classdef_content_return retval = new GbsParser.classdef_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.classdef_return se = default(GbsParser.classdef_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:2: (t= trigger | se= classdef )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= TRIGGER_INIT && LA7_0 <= TRIGGER_EVENT)) )
            {
                alt7 = 1;
            }
            else if ( ((LA7_0 >= CLASSDEF_ENGINE && LA7_0 <= CLASSDEF_EVENT)) )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:347:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_classdef_content1494);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:348:4: se= classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classdef_in_classdef_content1510);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:351:1: engine_classdef returns [Classdef en] : CLASSDEF_ENGINE '{' ( classdef_content )* '}' ;
    public GbsParser.engine_classdef_return engine_classdef() // throws RecognitionException [1]
    {   
        GbsParser.engine_classdef_return retval = new GbsParser.engine_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASSDEF_ENGINE29 = null;
        IToken char_literal30 = null;
        IToken char_literal32 = null;
        GbsParser.classdef_content_return classdef_content31 = default(GbsParser.classdef_content_return);


        object CLASSDEF_ENGINE29_tree=null;
        object char_literal30_tree=null;
        object char_literal32_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:2: ( CLASSDEF_ENGINE '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:4: CLASSDEF_ENGINE '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENGINE29=(IToken)Match(input,CLASSDEF_ENGINE,FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1535); 
            		CLASSDEF_ENGINE29_tree = (object)adaptor.Create(CLASSDEF_ENGINE29);
            		adaptor.AddChild(root_0, CLASSDEF_ENGINE29_tree);

            	char_literal30=(IToken)Match(input,63,FOLLOW_63_in_engine_classdef1537); 
            		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		adaptor.AddChild(root_0, char_literal30_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:24: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:24: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_engine_classdef1539);
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

            	char_literal32=(IToken)Match(input,64,FOLLOW_64_in_engine_classdef1542); 
            		char_literal32_tree = (object)adaptor.Create(char_literal32);
            		adaptor.AddChild(root_0, char_literal32_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:355:1: player_classdef returns [Classdef en] : CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.player_classdef_return player_classdef() // throws RecognitionException [1]
    {   
        GbsParser.player_classdef_return retval = new GbsParser.player_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_PLAYER33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        GbsParser.classdef_content_return classdef_content35 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_PLAYER33_tree=null;
        object char_literal34_tree=null;
        object char_literal36_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:2: ( CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:4: CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_PLAYER33=(IToken)Match(input,CLASSDEF_PLAYER,FOLLOW_CLASSDEF_PLAYER_in_player_classdef1560); 
            		CLASSDEF_PLAYER33_tree = (object)adaptor.Create(CLASSDEF_PLAYER33);
            		adaptor.AddChild(root_0, CLASSDEF_PLAYER33_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_classdef1564); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal34=(IToken)Match(input,63,FOLLOW_63_in_player_classdef1566); 
            		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_player_classdef1568);
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

            	char_literal36=(IToken)Match(input,64,FOLLOW_64_in_player_classdef1571); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:359:1: enemy_classdef returns [Classdef en] : CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.enemy_classdef_return enemy_classdef() // throws RecognitionException [1]
    {   
        GbsParser.enemy_classdef_return retval = new GbsParser.enemy_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_ENEMY37 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        GbsParser.classdef_content_return classdef_content39 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_ENEMY37_tree=null;
        object char_literal38_tree=null;
        object char_literal40_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:2: ( CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:4: CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENEMY37=(IToken)Match(input,CLASSDEF_ENEMY,FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1588); 
            		CLASSDEF_ENEMY37_tree = (object)adaptor.Create(CLASSDEF_ENEMY37);
            		adaptor.AddChild(root_0, CLASSDEF_ENEMY37_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1592); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal38=(IToken)Match(input,63,FOLLOW_63_in_enemy_classdef1594); 
            		char_literal38_tree = (object)adaptor.Create(char_literal38);
            		adaptor.AddChild(root_0, char_literal38_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_enemy_classdef1596);
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

            	char_literal40=(IToken)Match(input,64,FOLLOW_64_in_enemy_classdef1599); 
            		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		adaptor.AddChild(root_0, char_literal40_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:363:1: bullet_classdef returns [Classdef en] : CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.bullet_classdef_return bullet_classdef() // throws RecognitionException [1]
    {   
        GbsParser.bullet_classdef_return retval = new GbsParser.bullet_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_BULLET41 = null;
        IToken char_literal42 = null;
        IToken char_literal44 = null;
        GbsParser.classdef_content_return classdef_content43 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_BULLET41_tree=null;
        object char_literal42_tree=null;
        object char_literal44_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:2: ( CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:4: CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_BULLET41=(IToken)Match(input,CLASSDEF_BULLET,FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1616); 
            		CLASSDEF_BULLET41_tree = (object)adaptor.Create(CLASSDEF_BULLET41);
            		adaptor.AddChild(root_0, CLASSDEF_BULLET41_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1620); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal42=(IToken)Match(input,63,FOLLOW_63_in_bullet_classdef1622); 
            		char_literal42_tree = (object)adaptor.Create(char_literal42);
            		adaptor.AddChild(root_0, char_literal42_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_bullet_classdef1624);
            			    	classdef_content43 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal44=(IToken)Match(input,64,FOLLOW_64_in_bullet_classdef1627); 
            		char_literal44_tree = (object)adaptor.Create(char_literal44);
            		adaptor.AddChild(root_0, char_literal44_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:367:1: script_classdef returns [Classdef en] : CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.script_classdef_return script_classdef() // throws RecognitionException [1]
    {   
        GbsParser.script_classdef_return retval = new GbsParser.script_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_SCRIPT45 = null;
        IToken char_literal46 = null;
        IToken char_literal48 = null;
        GbsParser.classdef_content_return classdef_content47 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_SCRIPT45_tree=null;
        object char_literal46_tree=null;
        object char_literal48_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:2: ( CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:4: CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_SCRIPT45=(IToken)Match(input,CLASSDEF_SCRIPT,FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1645); 
            		CLASSDEF_SCRIPT45_tree = (object)adaptor.Create(CLASSDEF_SCRIPT45);
            		adaptor.AddChild(root_0, CLASSDEF_SCRIPT45_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_classdef1649); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal46=(IToken)Match(input,63,FOLLOW_63_in_script_classdef1651); 
            		char_literal46_tree = (object)adaptor.Create(char_literal46);
            		adaptor.AddChild(root_0, char_literal46_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:46: ( classdef_content )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= CLASSDEF_ENGINE && LA12_0 <= CLASSDEF_EVENT) || (LA12_0 >= TRIGGER_INIT && LA12_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_script_classdef1653);
            			    	classdef_content47 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content47.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal48=(IToken)Match(input,64,FOLLOW_64_in_script_classdef1656); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:371:1: state_classdef returns [Classdef en] : CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.state_classdef_return state_classdef() // throws RecognitionException [1]
    {   
        GbsParser.state_classdef_return retval = new GbsParser.state_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_STATE49 = null;
        IToken char_literal50 = null;
        IToken char_literal52 = null;
        GbsParser.classdef_content_return classdef_content51 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_STATE49_tree=null;
        object char_literal50_tree=null;
        object char_literal52_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:2: ( CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:4: CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_STATE49=(IToken)Match(input,CLASSDEF_STATE,FOLLOW_CLASSDEF_STATE_in_state_classdef1673); 
            		CLASSDEF_STATE49_tree = (object)adaptor.Create(CLASSDEF_STATE49);
            		adaptor.AddChild(root_0, CLASSDEF_STATE49_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_classdef1677); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal50=(IToken)Match(input,63,FOLLOW_63_in_state_classdef1679); 
            		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		adaptor.AddChild(root_0, char_literal50_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:45: ( classdef_content )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= CLASSDEF_ENGINE && LA13_0 <= CLASSDEF_EVENT) || (LA13_0 >= TRIGGER_INIT && LA13_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_state_classdef1681);
            			    	classdef_content51 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	char_literal52=(IToken)Match(input,64,FOLLOW_64_in_state_classdef1684); 
            		char_literal52_tree = (object)adaptor.Create(char_literal52);
            		adaptor.AddChild(root_0, char_literal52_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:375:1: event_classdef returns [Classdef en] : CLASSDEF_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_classdef_return event_classdef() // throws RecognitionException [1]
    {   
        GbsParser.event_classdef_return retval = new GbsParser.event_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_EVENT53 = null;

        object name_tree=null;
        object CLASSDEF_EVENT53_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:2: ( CLASSDEF_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:4: CLASSDEF_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_EVENT53=(IToken)Match(input,CLASSDEF_EVENT,FOLLOW_CLASSDEF_EVENT_in_event_classdef1703); 
            		CLASSDEF_EVENT53_tree = (object)adaptor.Create(CLASSDEF_EVENT53);
            		adaptor.AddChild(root_0, CLASSDEF_EVENT53_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_classdef1707); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:379:1: action_list returns [List<Action> actions] : ( action )* ;
    public GbsParser.action_list_return action_list() // throws RecognitionException [1]
    {   
        action_list_stack.Push(new action_list_scope());
        GbsParser.action_list_return retval = new GbsParser.action_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.action_return action54 = default(GbsParser.action_return);



         
        	((action_list_scope)action_list_stack.Peek()).list =  new List<Action>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:4: ( action )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == THIS || (LA14_0 >= PARAM_FPS && LA14_0 <= ACTION_RAISE) || LA14_0 == INSTANCE_IDENTIFIER) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:388:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1736);
            			    	action54 = action();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, action54.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:391:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
    public GbsParser.action_target_return action_target() // throws RecognitionException [1]
    {   
        GbsParser.action_target_return retval = new GbsParser.action_target_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ident = null;
        IToken THIS55 = null;

        object ident_tree=null;
        object THIS55_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == THIS || (LA16_0 >= ACTION_PERIODIC && LA16_0 <= ACTION_RAISE)) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == INSTANCE_IDENTIFIER) )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:4: ( THIS )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == THIS) )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:4: THIS
                    	        {
                    	        	THIS55=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target1754); 
                    	        		THIS55_tree = (object)adaptor.Create(THIS55);
                    	        		adaptor.AddChild(root_0, THIS55_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:393:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target1784); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:396:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:397:2: (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action )
            int alt17 = 9;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:397:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action1799);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:398:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action1808);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:399:4: fap= fire_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_action_in_action1824);
                    	fap = fire_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:400:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action1835);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:401:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action1856);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:402:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action1874);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:403:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action1894);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:404:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action1911);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:405:4: raa= raise_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_raise_action_in_action1931);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:408:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
    public GbsParser.play_animation_action_return play_animation_action() // throws RecognitionException [1]
    {   
        GbsParser.play_animation_action_return retval = new GbsParser.play_animation_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken ACTION_PLAY_ANIMATION56 = null;
        IToken char_literal57 = null;
        IToken char_literal58 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object anim_tree=null;
        object ACTION_PLAY_ANIMATION56_tree=null;
        object char_literal57_tree=null;
        object char_literal58_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:409:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:409:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action1953);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION56=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1955); 
            		ACTION_PLAY_ANIMATION56_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION56);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION56_tree);

            	char_literal57=(IToken)Match(input,59,FOLLOW_59_in_play_animation_action1957); 
            		char_literal57_tree = (object)adaptor.Create(char_literal57);
            		adaptor.AddChild(root_0, char_literal57_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action1961); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal58=(IToken)Match(input,60,FOLLOW_60_in_play_animation_action1963); 
            		char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:412:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken period = null;
        IToken ACTION_PERIODIC59 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        IToken char_literal62 = null;
        IToken char_literal63 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object period_tree=null;
        object ACTION_PERIODIC59_tree=null;
        object char_literal60_tree=null;
        object char_literal61_tree=null;
        object char_literal62_tree=null;
        object char_literal63_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:413:2: (target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:413:4: target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action1983);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC59=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action1985); 
            		ACTION_PERIODIC59_tree = (object)adaptor.Create(ACTION_PERIODIC59);
            		adaptor.AddChild(root_0, ACTION_PERIODIC59_tree);

            	char_literal60=(IToken)Match(input,59,FOLLOW_59_in_periodic_action1987); 
            		char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);

            	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action1991); 
            		period_tree = (object)adaptor.Create(period);
            		adaptor.AddChild(root_0, period_tree);

            	char_literal61=(IToken)Match(input,60,FOLLOW_60_in_periodic_action1993); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);

            	char_literal62=(IToken)Match(input,63,FOLLOW_63_in_periodic_action1995); 
            		char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action1999);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal63=(IToken)Match(input,64,FOLLOW_64_in_periodic_action2001); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:416:1: fire_action returns [Action action] : target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' ;
    public GbsParser.fire_action_return fire_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_action_return retval = new GbsParser.fire_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE64 = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return angle = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE64_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:417:2: (target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:417:4: target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_action2021);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE64=(IToken)Match(input,ACTION_FIRE,FOLLOW_ACTION_FIRE_in_fire_action2023); 
            		ACTION_FIRE64_tree = (object)adaptor.Create(ACTION_FIRE64);
            		adaptor.AddChild(root_0, ACTION_FIRE64_tree);

            	char_literal65=(IToken)Match(input,59,FOLLOW_59_in_fire_action2025); 
            		char_literal65_tree = (object)adaptor.Create(char_literal65);
            		adaptor.AddChild(root_0, char_literal65_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_action2029); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal66=(IToken)Match(input,62,FOLLOW_62_in_fire_action2031); 
            		char_literal66_tree = (object)adaptor.Create(char_literal66);
            		adaptor.AddChild(root_0, char_literal66_tree);

            	PushFollow(FOLLOW_formula_in_fire_action2035);
            	angle = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, angle.Tree);
            	char_literal67=(IToken)Match(input,60,FOLLOW_60_in_fire_action2037); 
            		char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:420:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE68 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE68_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action2057);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE68=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action2059); 
            		ACTION_DIE68_tree = (object)adaptor.Create(ACTION_DIE68);
            		adaptor.AddChild(root_0, ACTION_DIE68_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:424:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START69 = null;
        IToken char_literal70 = null;
        IToken char_literal71 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START69_tree=null;
        object char_literal70_tree=null;
        object char_literal71_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action2079);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START69=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action2081); 
            		ACTION_START69_tree = (object)adaptor.Create(ACTION_START69);
            		adaptor.AddChild(root_0, ACTION_START69_tree);

            	char_literal70=(IToken)Match(input,59,FOLLOW_59_in_start_action2083); 
            		char_literal70_tree = (object)adaptor.Create(char_literal70);
            		adaptor.AddChild(root_0, char_literal70_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action2087); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal71=(IToken)Match(input,60,FOLLOW_60_in_start_action2089); 
            		char_literal71_tree = (object)adaptor.Create(char_literal71);
            		adaptor.AddChild(root_0, char_literal71_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:428:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:429:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:429:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action2108);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP72=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action2110); 
            		ACTION_STOP72_tree = (object)adaptor.Create(ACTION_STOP72);
            		adaptor.AddChild(root_0, ACTION_STOP72_tree);

            	char_literal73=(IToken)Match(input,59,FOLLOW_59_in_stop_action2112); 
            		char_literal73_tree = (object)adaptor.Create(char_literal73);
            		adaptor.AddChild(root_0, char_literal73_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action2116); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal74=(IToken)Match(input,60,FOLLOW_60_in_stop_action2118); 
            		char_literal74_tree = (object)adaptor.Create(char_literal74);
            		adaptor.AddChild(root_0, char_literal74_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:432:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON75 = null;
        IToken char_literal76 = null;
        IToken char_literal77 = null;
        IToken char_literal78 = null;
        IToken char_literal79 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON75_tree=null;
        object char_literal76_tree=null;
        object char_literal77_tree=null;
        object char_literal78_tree=null;
        object char_literal79_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:433:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:433:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action2139);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON75=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action2141); 
            		ACTION_SUMMON75_tree = (object)adaptor.Create(ACTION_SUMMON75);
            		adaptor.AddChild(root_0, ACTION_SUMMON75_tree);

            	char_literal76=(IToken)Match(input,59,FOLLOW_59_in_summon_action2143); 
            		char_literal76_tree = (object)adaptor.Create(char_literal76);
            		adaptor.AddChild(root_0, char_literal76_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action2147); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal77=(IToken)Match(input,60,FOLLOW_60_in_summon_action2149); 
            		char_literal77_tree = (object)adaptor.Create(char_literal77);
            		adaptor.AddChild(root_0, char_literal77_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2153); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:433:95: ( '{' a= action_list '}' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 63) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:433:97: '{' a= action_list '}'
            	        {
            	        	char_literal78=(IToken)Match(input,63,FOLLOW_63_in_summon_action2157); 
            	        		char_literal78_tree = (object)adaptor.Create(char_literal78);
            	        		adaptor.AddChild(root_0, char_literal78_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action2161);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal79=(IToken)Match(input,64,FOLLOW_64_in_summon_action2163); 
            	        		char_literal79_tree = (object)adaptor.Create(char_literal79);
            	        		adaptor.AddChild(root_0, char_literal79_tree);


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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:436:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET80 = null;
        IToken char_literal81 = null;
        IToken char_literal82 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET80_tree=null;
        object char_literal81_tree=null;
        object char_literal82_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:437:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == THIS || (LA19_0 >= ACTION_PERIODIC && LA19_0 <= ACTION_RAISE) || LA19_0 == INSTANCE_IDENTIFIER) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= PARAM_FPS && LA19_0 <= PARAM_SCROLLING)) )
            {
                alt19 = 2;
            }
            else 
            {
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:437:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action2186);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET80=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action2188); 
                    		ACTION_SET80_tree = (object)adaptor.Create(ACTION_SET80);
                    		adaptor.AddChild(root_0, ACTION_SET80_tree);

                    	char_literal81=(IToken)Match(input,59,FOLLOW_59_in_set_action2190); 
                    		char_literal81_tree = (object)adaptor.Create(char_literal81);
                    		adaptor.AddChild(root_0, char_literal81_tree);

                    	PushFollow(FOLLOW_param_in_set_action2194);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal82=(IToken)Match(input,60,FOLLOW_60_in_set_action2196); 
                    		char_literal82_tree = (object)adaptor.Create(char_literal82);
                    		adaptor.AddChild(root_0, char_literal82_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:438:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action2205);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:441:1: raise_action returns [Action action] : target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' ;
    public GbsParser.raise_action_return raise_action() // throws RecognitionException [1]
    {   
        GbsParser.raise_action_return retval = new GbsParser.raise_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e = null;
        IToken ACTION_RAISE83 = null;
        IToken char_literal84 = null;
        IToken char_literal85 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object e_tree=null;
        object ACTION_RAISE83_tree=null;
        object char_literal84_tree=null;
        object char_literal85_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:2: (target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:4: target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_raise_action2265);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_RAISE83=(IToken)Match(input,ACTION_RAISE,FOLLOW_ACTION_RAISE_in_raise_action2267); 
            		ACTION_RAISE83_tree = (object)adaptor.Create(ACTION_RAISE83);
            		adaptor.AddChild(root_0, ACTION_RAISE83_tree);

            	char_literal84=(IToken)Match(input,59,FOLLOW_59_in_raise_action2269); 
            		char_literal84_tree = (object)adaptor.Create(char_literal84);
            		adaptor.AddChild(root_0, char_literal84_tree);

            	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_raise_action2273); 
            		e_tree = (object)adaptor.Create(e);
            		adaptor.AddChild(root_0, e_tree);

            	char_literal85=(IToken)Match(input,60,FOLLOW_60_in_raise_action2275); 
            		char_literal85_tree = (object)adaptor.Create(char_literal85);
            		adaptor.AddChild(root_0, char_literal85_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:445:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
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
        IToken TRIGGER_INIT86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken TRIGGER_CLEANUP89 = null;
        IToken char_literal90 = null;
        IToken char_literal91 = null;
        IToken TRIGGER_TIME92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        IToken TRIGGER_PERIODIC97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        IToken char_literal100 = null;
        IToken char_literal101 = null;
        IToken TRIGGER_SCROLLING102 = null;
        IToken char_literal103 = null;
        IToken char_literal104 = null;
        IToken char_literal105 = null;
        IToken char_literal106 = null;
        IToken TRIGGER_ANIMATION_END107 = null;
        IToken char_literal108 = null;
        IToken char_literal109 = null;
        IToken char_literal110 = null;
        IToken char_literal111 = null;
        IToken TRIGGER_EVENT112 = null;
        IToken char_literal113 = null;
        IToken char_literal114 = null;
        IToken char_literal115 = null;
        IToken char_literal116 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object period_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object TRIGGER_CLEANUP89_tree=null;
        object char_literal90_tree=null;
        object char_literal91_tree=null;
        object TRIGGER_TIME92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;
        object TRIGGER_PERIODIC97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;
        object char_literal100_tree=null;
        object char_literal101_tree=null;
        object TRIGGER_SCROLLING102_tree=null;
        object char_literal103_tree=null;
        object char_literal104_tree=null;
        object char_literal105_tree=null;
        object char_literal106_tree=null;
        object TRIGGER_ANIMATION_END107_tree=null;
        object char_literal108_tree=null;
        object char_literal109_tree=null;
        object char_literal110_tree=null;
        object char_literal111_tree=null;
        object TRIGGER_EVENT112_tree=null;
        object char_literal113_tree=null;
        object char_literal114_tree=null;
        object char_literal115_tree=null;
        object char_literal116_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
            int alt20 = 7;
            switch ( input.LA(1) ) 
            {
            case TRIGGER_INIT:
            	{
                alt20 = 1;
                }
                break;
            case TRIGGER_CLEANUP:
            	{
                alt20 = 2;
                }
                break;
            case TRIGGER_TIME:
            	{
                alt20 = 3;
                }
                break;
            case TRIGGER_PERIODIC:
            	{
                alt20 = 4;
                }
                break;
            case TRIGGER_SCROLLING:
            	{
                alt20 = 5;
                }
                break;
            case TRIGGER_ANIMATION_END:
            	{
                alt20 = 6;
                }
                break;
            case TRIGGER_EVENT:
            	{
                alt20 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            }

            switch (alt20) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT86=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger2293); 
                    		TRIGGER_INIT86_tree = (object)adaptor.Create(TRIGGER_INIT86);
                    		adaptor.AddChild(root_0, TRIGGER_INIT86_tree);

                    	char_literal87=(IToken)Match(input,63,FOLLOW_63_in_trigger2295); 
                    		char_literal87_tree = (object)adaptor.Create(char_literal87);
                    		adaptor.AddChild(root_0, char_literal87_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2299);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal88=(IToken)Match(input,64,FOLLOW_64_in_trigger2301); 
                    		char_literal88_tree = (object)adaptor.Create(char_literal88);
                    		adaptor.AddChild(root_0, char_literal88_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:447:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP89=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2337); 
                    		TRIGGER_CLEANUP89_tree = (object)adaptor.Create(TRIGGER_CLEANUP89);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP89_tree);

                    	char_literal90=(IToken)Match(input,63,FOLLOW_63_in_trigger2339); 
                    		char_literal90_tree = (object)adaptor.Create(char_literal90);
                    		adaptor.AddChild(root_0, char_literal90_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2343);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal91=(IToken)Match(input,64,FOLLOW_64_in_trigger2345); 
                    		char_literal91_tree = (object)adaptor.Create(char_literal91);
                    		adaptor.AddChild(root_0, char_literal91_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:448:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME92=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2378); 
                    		TRIGGER_TIME92_tree = (object)adaptor.Create(TRIGGER_TIME92);
                    		adaptor.AddChild(root_0, TRIGGER_TIME92_tree);

                    	char_literal93=(IToken)Match(input,59,FOLLOW_59_in_trigger2380); 
                    		char_literal93_tree = (object)adaptor.Create(char_literal93);
                    		adaptor.AddChild(root_0, char_literal93_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2384); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal94=(IToken)Match(input,60,FOLLOW_60_in_trigger2386); 
                    		char_literal94_tree = (object)adaptor.Create(char_literal94);
                    		adaptor.AddChild(root_0, char_literal94_tree);

                    	char_literal95=(IToken)Match(input,63,FOLLOW_63_in_trigger2388); 
                    		char_literal95_tree = (object)adaptor.Create(char_literal95);
                    		adaptor.AddChild(root_0, char_literal95_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2392);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal96=(IToken)Match(input,64,FOLLOW_64_in_trigger2394); 
                    		char_literal96_tree = (object)adaptor.Create(char_literal96);
                    		adaptor.AddChild(root_0, char_literal96_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:449:4: TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_PERIODIC97=(IToken)Match(input,TRIGGER_PERIODIC,FOLLOW_TRIGGER_PERIODIC_in_trigger2410); 
                    		TRIGGER_PERIODIC97_tree = (object)adaptor.Create(TRIGGER_PERIODIC97);
                    		adaptor.AddChild(root_0, TRIGGER_PERIODIC97_tree);

                    	char_literal98=(IToken)Match(input,59,FOLLOW_59_in_trigger2412); 
                    		char_literal98_tree = (object)adaptor.Create(char_literal98);
                    		adaptor.AddChild(root_0, char_literal98_tree);

                    	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2416); 
                    		period_tree = (object)adaptor.Create(period);
                    		adaptor.AddChild(root_0, period_tree);

                    	char_literal99=(IToken)Match(input,60,FOLLOW_60_in_trigger2418); 
                    		char_literal99_tree = (object)adaptor.Create(char_literal99);
                    		adaptor.AddChild(root_0, char_literal99_tree);

                    	char_literal100=(IToken)Match(input,63,FOLLOW_63_in_trigger2420); 
                    		char_literal100_tree = (object)adaptor.Create(char_literal100);
                    		adaptor.AddChild(root_0, char_literal100_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2424);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal101=(IToken)Match(input,64,FOLLOW_64_in_trigger2426); 
                    		char_literal101_tree = (object)adaptor.Create(char_literal101);
                    		adaptor.AddChild(root_0, char_literal101_tree);

                    	 retval.t =  new PeriodicTrigger(float.Parse(period.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:450:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING102=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2433); 
                    		TRIGGER_SCROLLING102_tree = (object)adaptor.Create(TRIGGER_SCROLLING102);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING102_tree);

                    	char_literal103=(IToken)Match(input,59,FOLLOW_59_in_trigger2435); 
                    		char_literal103_tree = (object)adaptor.Create(char_literal103);
                    		adaptor.AddChild(root_0, char_literal103_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2439); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal104=(IToken)Match(input,60,FOLLOW_60_in_trigger2441); 
                    		char_literal104_tree = (object)adaptor.Create(char_literal104);
                    		adaptor.AddChild(root_0, char_literal104_tree);

                    	char_literal105=(IToken)Match(input,63,FOLLOW_63_in_trigger2443); 
                    		char_literal105_tree = (object)adaptor.Create(char_literal105);
                    		adaptor.AddChild(root_0, char_literal105_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2447);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal106=(IToken)Match(input,64,FOLLOW_64_in_trigger2449); 
                    		char_literal106_tree = (object)adaptor.Create(char_literal106);
                    		adaptor.AddChild(root_0, char_literal106_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:451:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END107=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2458); 
                    		TRIGGER_ANIMATION_END107_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END107);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END107_tree);

                    	char_literal108=(IToken)Match(input,59,FOLLOW_59_in_trigger2460); 
                    		char_literal108_tree = (object)adaptor.Create(char_literal108);
                    		adaptor.AddChild(root_0, char_literal108_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2464); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal109=(IToken)Match(input,60,FOLLOW_60_in_trigger2466); 
                    		char_literal109_tree = (object)adaptor.Create(char_literal109);
                    		adaptor.AddChild(root_0, char_literal109_tree);

                    	char_literal110=(IToken)Match(input,63,FOLLOW_63_in_trigger2468); 
                    		char_literal110_tree = (object)adaptor.Create(char_literal110);
                    		adaptor.AddChild(root_0, char_literal110_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2472);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal111=(IToken)Match(input,64,FOLLOW_64_in_trigger2474); 
                    		char_literal111_tree = (object)adaptor.Create(char_literal111);
                    		adaptor.AddChild(root_0, char_literal111_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:452:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT112=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2481); 
                    		TRIGGER_EVENT112_tree = (object)adaptor.Create(TRIGGER_EVENT112);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT112_tree);

                    	char_literal113=(IToken)Match(input,59,FOLLOW_59_in_trigger2483); 
                    		char_literal113_tree = (object)adaptor.Create(char_literal113);
                    		adaptor.AddChild(root_0, char_literal113_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2487); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal114=(IToken)Match(input,60,FOLLOW_60_in_trigger2489); 
                    		char_literal114_tree = (object)adaptor.Create(char_literal114);
                    		adaptor.AddChild(root_0, char_literal114_tree);

                    	char_literal115=(IToken)Match(input,63,FOLLOW_63_in_trigger2491); 
                    		char_literal115_tree = (object)adaptor.Create(char_literal115);
                    		adaptor.AddChild(root_0, char_literal115_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2495);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal116=(IToken)Match(input,64,FOLLOW_64_in_trigger2497); 
                    		char_literal116_tree = (object)adaptor.Create(char_literal116);
                    		adaptor.AddChild(root_0, char_literal116_tree);

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


   	protected DFA4 dfa4;
   	protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa17 = new DFA17(this);


	}

    const string DFA4_eotS =
        "\x0b\uffff";
    const string DFA4_eofS =
        "\x0b\uffff";
    const string DFA4_minS =
        "\x01\x23\x01\x36\x09\uffff";
    const string DFA4_maxS =
        "\x01\x3b\x01\x3c\x09\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x09\x01"+
        "\x02\x01\x08\x01\x01";
    const string DFA4_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x06\x01\x02\x01\x03\x01\x04\x01\x05\x03\uffff\x01\x01"+
            "\x0f\uffff\x01\x07",
            "\x03\x0a\x01\x08\x01\x09\x01\uffff\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "276:1: simple_formula returns [Formula formula] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | a= NUMBER '..' b= NUMBER | '(' f= formula ')' );"; }
        }

    }

    const string DFA17_eotS =
        "\x0c\uffff";
    const string DFA17_eofS =
        "\x0c\uffff";
    const string DFA17_minS =
        "\x01\x04\x01\x13\x01\uffff\x01\x13\x08\uffff";
    const string DFA17_maxS =
        "\x01\x31\x01\x1b\x01\uffff\x01\x1b\x08\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09";
    const string DFA17_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA17_transitionS = {
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

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "396:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_classdef_in_gbs949 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula981 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_54_in_formula985 = new BitSet(new ulong[]{0x080008F800000000UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula989 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_55_in_formula995 = new BitSet(new ulong[]{0x080008F800000000UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula999 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1024 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_factor_formula1028 = new BitSet(new ulong[]{0x080008F800000000UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1032 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1062 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_simple_formula1064 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_UP_in_simple_formula1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1108 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_simple_formula1110 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_simple_formula1121 = new BitSet(new ulong[]{0x080008F800000000UL});
    public static readonly BitSet FOLLOW_formula_in_simple_formula1125 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_simple_formula1127 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fps_param_in_param1147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param1163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param1173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param1222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param1239 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_fps_param1241 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param1245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1262 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_gamearea_param1264 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1286 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_position_param1288 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1310 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_speed_param1312 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1316 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1334 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_animation_param1336 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1358 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_color_param1360 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1382 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_scrolling_param1384 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1388 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_scrolling_param1390 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_classdef_in_classdef1425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_classdef_in_classdef1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_classdef_in_classdef1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_classdef_in_classdef1452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_classdef_in_classdef1461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_classdef_in_classdef1470 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_classdef_in_classdef1479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_classdef_content1494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_classdef_content1510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1535 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_engine_classdef1537 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_engine_classdef1539 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_engine_classdef1542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_PLAYER_in_player_classdef1560 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_classdef1564 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_player_classdef1566 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_player_classdef1568 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_player_classdef1571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1588 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1592 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_enemy_classdef1594 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_enemy_classdef1596 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_enemy_classdef1599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1616 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1620 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_bullet_classdef1622 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_bullet_classdef1624 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_bullet_classdef1627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1645 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_classdef1649 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_script_classdef1651 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_script_classdef1653 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_script_classdef1656 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_STATE_in_state_classdef1673 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_classdef1677 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_state_classdef1679 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_classdef_content_in_state_classdef1681 = new BitSet(new ulong[]{0x00000007F0000FE0UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_state_classdef1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_EVENT_in_event_classdef1703 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_classdef1707 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1736 = new BitSet(new ulong[]{0x000200000FFFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target1754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action1799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action1808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_action_in_action1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action1835 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action1856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action1874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action1894 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action1911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_raise_action_in_action1931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action1953 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action1955 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_play_animation_action1957 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action1961 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_play_animation_action1963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action1983 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action1985 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_periodic_action1987 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action1991 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_periodic_action1993 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_periodic_action1995 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action1999 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_periodic_action2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_action2021 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_in_fire_action2023 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_fire_action2025 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_action2029 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_fire_action2031 = new BitSet(new ulong[]{0x080008F800000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_action2035 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_fire_action2037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action2057 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action2059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action2079 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action2081 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_start_action2083 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action2087 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_start_action2089 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action2108 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action2110 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_stop_action2112 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action2116 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_stop_action2118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action2139 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action2141 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_summon_action2143 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action2147 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_summon_action2149 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2153 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_summon_action2157 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action2161 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_summon_action2163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action2186 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action2188 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_set_action2190 = new BitSet(new ulong[]{0x000200000407F010UL});
    public static readonly BitSet FOLLOW_param_in_set_action2194 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_set_action2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action2205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_raise_action2265 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ACTION_RAISE_in_raise_action2267 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_raise_action2269 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_raise_action2273 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_raise_action2275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger2293 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2295 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2299 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2337 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2339 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2343 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2378 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2380 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2384 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_trigger2386 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2388 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2392 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_PERIODIC_in_trigger2410 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2412 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2416 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_trigger2418 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2420 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2424 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2433 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2435 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2439 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_trigger2441 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2443 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2447 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2458 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2460 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2464 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_trigger2466 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2468 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2481 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2483 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2487 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_trigger2489 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_trigger2491 = new BitSet(new ulong[]{0x000200000FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2495 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_trigger2497 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}