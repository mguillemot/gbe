// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-11-02 19:02:54
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
		"ACTION_FIRE_MULTIPLE", 
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
		"PREDEF_ANGLE_CURRENT", 
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
		"'/'", 
		"'°'", 
		"'('", 
		"')'", 
		"'..'", 
		"'='", 
		"','", 
		"'{'", 
		"'}'"
    };

    public const int DIRECTION = 46;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int CONST_ANGLE_RIGHT = 41;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int ACTION_SET = 27;
    public const int POINT = 48;
    public const int TRIGGER_SCROLLING = 33;
    public const int CLASSDEF_SCRIPT = 9;
    public const int CONST_ANGLE_UP = 39;
    public const int ACTION_FIRE_MULTIPLE = 21;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 43;
    public const int CLASSDEF_BULLET = 7;
    public const int TRIGGER_CLEANUP = 30;
    public const int ML_COMMENT = 54;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int PARAM_ANIMATION = 17;
    public const int INSTANCE_IDENTIFIER = 51;
    public const int CONST_ANGLE_DOWN = 38;
    public const int TRIGGER_INIT = 29;
    public const int T__59 = 59;
    public const int ACTION_START = 23;
    public const int THIS = 4;
    public const int RECTANGLE = 49;
    public const int CLASSDEF_PLAYER = 6;
    public const int PARAM_POSITION = 14;
    public const int DIGIT = 47;
    public const int CLASSDEF_EVENT = 11;
    public const int ACTION_PERIODIC = 19;
    public const int PARAM_GAMEAREA = 13;
    public const int PARAM_FPS = 12;
    public const int PREDEF_ANGLE_CURRENT = 37;
    public const int CLASSDEF_ENEMY = 8;
    public const int ACTION_SUMMON = 25;
    public const int NUMBER = 45;
    public const int WHITESPACE = 53;
    public const int HEX_DIGIT = 42;
    public const int TRIGGER_TIME = 31;
    public const int ACTION_STOP = 24;
    public const int TRIGGER_PERIODIC = 32;
    public const int TRIGGER_ANIMATION_END = 34;
    public const int ACTION_FIRE = 20;
    public const int TRIGGER_EVENT = 35;
    public const int CLASSDEF_STATE = 10;
    public const int CARDINAL_DIRECTION = 44;
    public const int PARAM_COLOR = 15;
    public const int PARAM_SPEED = 16;
    public const int CLASS_IDENTIFIER = 50;
    public const int CONST_ANGLE_LEFT = 40;
    public const int ACTION_RAISE = 28;
    public const int SL_COMMENT = 55;
    public const int PREDEF_ANGLE_TOWARD_PLAYER = 36;
    public const int ACTION_DIE = 22;
    public const int CLASSDEF_ENGINE = 5;
    public const int ACTION_PLAY_ANIMATION = 26;
    public const int STRING = 52;

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:254:1: gbs returns [Gbs s] : ( classdef )* ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:2: ( ( classdef )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:4: ( classdef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:4: ( classdef )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:263:4: classdef
            			    {
            			    	PushFollow(FOLLOW_classdef_in_gbs971);
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
        public Formula f;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:266:1: formula returns [Formula f] : a= factor_formula ( ( '+' | '-' ) b= factor_formula )* ;
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

         
        	((formula_scope)formula_stack.Peek()).add =  new List<bool>();
        	((formula_scope)formula_stack.Peek()).terms =  new List<Formula>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:2: (a= factor_formula ( ( '+' | '-' ) b= factor_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:4: a= factor_formula ( ( '+' | '-' ) b= factor_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_factor_formula_in_formula1003);
            	a = factor_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:21: ( ( '+' | '-' ) b= factor_formula )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= 56 && LA3_0 <= 57)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:23: ( '+' | '-' ) b= factor_formula
            			    {
            			    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:23: ( '+' | '-' )
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == 56) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	else if ( (LA2_0 == 57) )
            			    	{
            			    	    alt2 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d2s0 =
            			    	        new NoViableAltException("", 2, 0, input);

            			    	    throw nvae_d2s0;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:25: '+'
            			    	        {
            			    	        	char_literal2=(IToken)Match(input,56,FOLLOW_56_in_formula1009); 
            			    	        		char_literal2_tree = (object)adaptor.Create(char_literal2);
            			    	        		adaptor.AddChild(root_0, char_literal2_tree);

            			    	        	 ((formula_scope)formula_stack.Peek()).add.Add(true); 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:277:60: '-'
            			    	        {
            			    	        	char_literal3=(IToken)Match(input,57,FOLLOW_57_in_formula1015); 
            			    	        		char_literal3_tree = (object)adaptor.Create(char_literal3);
            			    	        		adaptor.AddChild(root_0, char_literal3_tree);

            			    	        	 ((formula_scope)formula_stack.Peek()).add.Add(false); 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_factor_formula_in_formula1023);
            			    	b = factor_formula();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, b.Tree);
            			    	 ((formula_scope)formula_stack.Peek()).terms.Add(((b != null) ? b.f : default(Formula))); 

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	 retval.f =  new RawSumFormula(((a != null) ? a.f : default(Formula)), ((formula_scope)formula_stack.Peek()).add, ((formula_scope)formula_stack.Peek()).terms); 

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

    protected class factor_formula_scope 
    {
        protected internal List<bool> mul;
        protected internal List<Formula> factors;
    }
    protected Stack factor_formula_stack = new Stack();

    public class factor_formula_return : ParserRuleReturnScope
    {
        public Formula f;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "factor_formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:280:1: factor_formula returns [Formula f] : a= simple_formula ( ( '*' | '/' ) b= simple_formula )* ;
    public GbsParser.factor_formula_return factor_formula() // throws RecognitionException [1]
    {   
        factor_formula_stack.Push(new factor_formula_scope());
        GbsParser.factor_formula_return retval = new GbsParser.factor_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal4 = null;
        IToken char_literal5 = null;
        GbsParser.simple_formula_return a = default(GbsParser.simple_formula_return);

        GbsParser.simple_formula_return b = default(GbsParser.simple_formula_return);


        object char_literal4_tree=null;
        object char_literal5_tree=null;

         
        	((factor_formula_scope)factor_formula_stack.Peek()).mul =  new List<bool>();
        	((factor_formula_scope)factor_formula_stack.Peek()).factors =  new List<Formula>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:2: (a= simple_formula ( ( '*' | '/' ) b= simple_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:4: a= simple_formula ( ( '*' | '/' ) b= simple_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_simple_formula_in_factor_formula1060);
            	a = simple_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:21: ( ( '*' | '/' ) b= simple_formula )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= 58 && LA5_0 <= 59)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:23: ( '*' | '/' ) b= simple_formula
            			    {
            			    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:23: ( '*' | '/' )
            			    	int alt4 = 2;
            			    	int LA4_0 = input.LA(1);

            			    	if ( (LA4_0 == 58) )
            			    	{
            			    	    alt4 = 1;
            			    	}
            			    	else if ( (LA4_0 == 59) )
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
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:25: '*'
            			    	        {
            			    	        	char_literal4=(IToken)Match(input,58,FOLLOW_58_in_factor_formula1066); 
            			    	        		char_literal4_tree = (object)adaptor.Create(char_literal4);
            			    	        		adaptor.AddChild(root_0, char_literal4_tree);

            			    	        	 ((factor_formula_scope)factor_formula_stack.Peek()).mul.Add(true); 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:291:67: '/'
            			    	        {
            			    	        	char_literal5=(IToken)Match(input,59,FOLLOW_59_in_factor_formula1072); 
            			    	        		char_literal5_tree = (object)adaptor.Create(char_literal5);
            			    	        		adaptor.AddChild(root_0, char_literal5_tree);

            			    	        	 ((factor_formula_scope)factor_formula_stack.Peek()).mul.Add(false); 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_simple_formula_in_factor_formula1080);
            			    	b = simple_formula();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, b.Tree);
            			    	 ((factor_formula_scope)factor_formula_stack.Peek()).factors.Add(((b != null) ? b.f : default(Formula))); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	 retval.f =  new RawMultiplyFormula(((a != null) ? a.f : default(Formula)), ((factor_formula_scope)factor_formula_stack.Peek()).mul, ((factor_formula_scope)factor_formula_stack.Peek()).factors); 

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
            factor_formula_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "factor_formula"

    public class simple_formula_return : ParserRuleReturnScope
    {
        public Formula f;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simple_formula"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:294:1: simple_formula returns [Formula f] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | '(' sf= formula ')' );
    public GbsParser.simple_formula_return simple_formula() // throws RecognitionException [1]
    {   
        GbsParser.simple_formula_return retval = new GbsParser.simple_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken c = null;
        IToken char_literal6 = null;
        IToken CONST_ANGLE_DOWN7 = null;
        IToken CONST_ANGLE_UP8 = null;
        IToken CONST_ANGLE_LEFT9 = null;
        IToken CONST_ANGLE_RIGHT10 = null;
        IToken PREDEF_ANGLE_TOWARD_PLAYER11 = null;
        IToken PREDEF_ANGLE_CURRENT12 = null;
        IToken char_literal13 = null;
        IToken char_literal14 = null;
        GbsParser.formula_return sf = default(GbsParser.formula_return);


        object c_tree=null;
        object char_literal6_tree=null;
        object CONST_ANGLE_DOWN7_tree=null;
        object CONST_ANGLE_UP8_tree=null;
        object CONST_ANGLE_LEFT9_tree=null;
        object CONST_ANGLE_RIGHT10_tree=null;
        object PREDEF_ANGLE_TOWARD_PLAYER11_tree=null;
        object PREDEF_ANGLE_CURRENT12_tree=null;
        object char_literal13_tree=null;
        object char_literal14_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:295:2: (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | '(' sf= formula ')' )
            int alt6 = 9;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:295:4: c= NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1104); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	 retval.f =  new ConstValueFormula(float.Parse(c.Text)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:296:4: c= NUMBER '°'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1113); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	char_literal6=(IToken)Match(input,60,FOLLOW_60_in_simple_formula1115); 
                    		char_literal6_tree = (object)adaptor.Create(char_literal6);
                    		adaptor.AddChild(root_0, char_literal6_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.DegreeToRadian(float.Parse(c.Text))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:297:4: CONST_ANGLE_DOWN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_DOWN7=(IToken)Match(input,CONST_ANGLE_DOWN,FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1122); 
                    		CONST_ANGLE_DOWN7_tree = (object)adaptor.Create(CONST_ANGLE_DOWN7);
                    		adaptor.AddChild(root_0, CONST_ANGLE_DOWN7_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_DOWN); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:4: CONST_ANGLE_UP
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_UP8=(IToken)Match(input,CONST_ANGLE_UP,FOLLOW_CONST_ANGLE_UP_in_simple_formula1129); 
                    		CONST_ANGLE_UP8_tree = (object)adaptor.Create(CONST_ANGLE_UP8);
                    		adaptor.AddChild(root_0, CONST_ANGLE_UP8_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_UP); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:299:4: CONST_ANGLE_LEFT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_LEFT9=(IToken)Match(input,CONST_ANGLE_LEFT,FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1136); 
                    		CONST_ANGLE_LEFT9_tree = (object)adaptor.Create(CONST_ANGLE_LEFT9);
                    		adaptor.AddChild(root_0, CONST_ANGLE_LEFT9_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_LEFT); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:300:4: CONST_ANGLE_RIGHT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_RIGHT10=(IToken)Match(input,CONST_ANGLE_RIGHT,FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1143); 
                    		CONST_ANGLE_RIGHT10_tree = (object)adaptor.Create(CONST_ANGLE_RIGHT10);
                    		adaptor.AddChild(root_0, CONST_ANGLE_RIGHT10_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_RIGHT); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:301:4: PREDEF_ANGLE_TOWARD_PLAYER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_TOWARD_PLAYER11=(IToken)Match(input,PREDEF_ANGLE_TOWARD_PLAYER,FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1150); 
                    		PREDEF_ANGLE_TOWARD_PLAYER11_tree = (object)adaptor.Create(PREDEF_ANGLE_TOWARD_PLAYER11);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_TOWARD_PLAYER11_tree);

                    	 retval.f =  new AngleTowardPlayerFormula(); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:302:4: PREDEF_ANGLE_CURRENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_CURRENT12=(IToken)Match(input,PREDEF_ANGLE_CURRENT,FOLLOW_PREDEF_ANGLE_CURRENT_in_simple_formula1157); 
                    		PREDEF_ANGLE_CURRENT12_tree = (object)adaptor.Create(PREDEF_ANGLE_CURRENT12);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_CURRENT12_tree);

                    	 retval.f =  new CurrentAngleFormula(); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:303:4: '(' sf= formula ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal13=(IToken)Match(input,61,FOLLOW_61_in_simple_formula1164); 
                    		char_literal13_tree = (object)adaptor.Create(char_literal13);
                    		adaptor.AddChild(root_0, char_literal13_tree);

                    	PushFollow(FOLLOW_formula_in_simple_formula1168);
                    	sf = formula();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sf.Tree);
                    	char_literal14=(IToken)Match(input,62,FOLLOW_62_in_simple_formula1170); 
                    		char_literal14_tree = (object)adaptor.Create(char_literal14);
                    		adaptor.AddChild(root_0, char_literal14_tree);

                    	 retval.f =  ((sf != null) ? sf.f : default(Formula)); 

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

    public class range_return : ParserRuleReturnScope
    {
        public Range range;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "range"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:306:1: range returns [Range range] : a= NUMBER '..' b= NUMBER ;
    public GbsParser.range_return range() // throws RecognitionException [1]
    {   
        GbsParser.range_return retval = new GbsParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken string_literal15 = null;

        object a_tree=null;
        object b_tree=null;
        object string_literal15_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:307:2: (a= NUMBER '..' b= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:307:4: a= NUMBER '..' b= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	a=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_range1190); 
            		a_tree = (object)adaptor.Create(a);
            		adaptor.AddChild(root_0, a_tree);

            	string_literal15=(IToken)Match(input,63,FOLLOW_63_in_range1192); 
            		string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);

            	b=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_range1196); 
            		b_tree = (object)adaptor.Create(b);
            		adaptor.AddChild(root_0, b_tree);

            	 retval.range =  new Range(float.Parse(a.Text), float.Parse(b.Text)); 

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
    // $ANTLR end "range"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:310:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:311:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param )
            int alt7 = 7;
            switch ( input.LA(1) ) 
            {
            case PARAM_FPS:
            	{
                alt7 = 1;
                }
                break;
            case PARAM_GAMEAREA:
            	{
                alt7 = 2;
                }
                break;
            case PARAM_POSITION:
            	{
                alt7 = 3;
                }
                break;
            case PARAM_SPEED:
            	{
                alt7 = 4;
                }
                break;
            case PARAM_ANIMATION:
            	{
                alt7 = 5;
                }
                break;
            case PARAM_COLOR:
            	{
                alt7 = 6;
                }
                break;
            case PARAM_SCROLLING:
            	{
                alt7 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:311:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param1216);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param1232);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:313:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param1242);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:314:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param1253);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:315:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param1267);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param1277);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:317:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param1291);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
    public GbsParser.fps_param_return fps_param() // throws RecognitionException [1]
    {   
        GbsParser.fps_param_return retval = new GbsParser.fps_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken fps = null;
        IToken PARAM_FPS16 = null;
        IToken char_literal17 = null;

        object fps_tree=null;
        object PARAM_FPS16_tree=null;
        object char_literal17_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:321:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:321:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS16=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param1308); 
            		PARAM_FPS16_tree = (object)adaptor.Create(PARAM_FPS16);
            		adaptor.AddChild(root_0, PARAM_FPS16_tree);

            	char_literal17=(IToken)Match(input,64,FOLLOW_64_in_fps_param1310); 
            		char_literal17_tree = (object)adaptor.Create(char_literal17);
            		adaptor.AddChild(root_0, char_literal17_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param1314); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:324:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
    public GbsParser.gamearea_param_return gamearea_param() // throws RecognitionException [1]
    {   
        GbsParser.gamearea_param_return retval = new GbsParser.gamearea_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken area = null;
        IToken PARAM_GAMEAREA18 = null;
        IToken char_literal19 = null;

        object area_tree=null;
        object PARAM_GAMEAREA18_tree=null;
        object char_literal19_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:325:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:325:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA18=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1331); 
            		PARAM_GAMEAREA18_tree = (object)adaptor.Create(PARAM_GAMEAREA18);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA18_tree);

            	char_literal19=(IToken)Match(input,64,FOLLOW_64_in_gamearea_param1333); 
            		char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1337); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:328:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
    public GbsParser.position_param_return position_param() // throws RecognitionException [1]
    {   
        GbsParser.position_param_return retval = new GbsParser.position_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken pos = null;
        IToken PARAM_POSITION20 = null;
        IToken char_literal21 = null;

        object pos_tree=null;
        object PARAM_POSITION20_tree=null;
        object char_literal21_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:329:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:329:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION20=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1355); 
            		PARAM_POSITION20_tree = (object)adaptor.Create(PARAM_POSITION20);
            		adaptor.AddChild(root_0, PARAM_POSITION20_tree);

            	char_literal21=(IToken)Match(input,64,FOLLOW_64_in_position_param1357); 
            		char_literal21_tree = (object)adaptor.Create(char_literal21);
            		adaptor.AddChild(root_0, char_literal21_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1361); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:332:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
    public GbsParser.speed_param_return speed_param() // throws RecognitionException [1]
    {   
        GbsParser.speed_param_return retval = new GbsParser.speed_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken speed = null;
        IToken PARAM_SPEED22 = null;
        IToken char_literal23 = null;

        object speed_tree=null;
        object PARAM_SPEED22_tree=null;
        object char_literal23_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:333:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:333:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED22=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1379); 
            		PARAM_SPEED22_tree = (object)adaptor.Create(PARAM_SPEED22);
            		adaptor.AddChild(root_0, PARAM_SPEED22_tree);

            	char_literal23=(IToken)Match(input,64,FOLLOW_64_in_speed_param1381); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1385); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
    public GbsParser.animation_param_return animation_param() // throws RecognitionException [1]
    {   
        GbsParser.animation_param_return retval = new GbsParser.animation_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken PARAM_ANIMATION24 = null;
        IToken char_literal25 = null;

        object anim_tree=null;
        object PARAM_ANIMATION24_tree=null;
        object char_literal25_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:337:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:337:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION24=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1403); 
            		PARAM_ANIMATION24_tree = (object)adaptor.Create(PARAM_ANIMATION24);
            		adaptor.AddChild(root_0, PARAM_ANIMATION24_tree);

            	char_literal25=(IToken)Match(input,64,FOLLOW_64_in_animation_param1405); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1409); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
    public GbsParser.color_param_return color_param() // throws RecognitionException [1]
    {   
        GbsParser.color_param_return retval = new GbsParser.color_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken color = null;
        IToken PARAM_COLOR26 = null;
        IToken char_literal27 = null;

        object color_tree=null;
        object PARAM_COLOR26_tree=null;
        object char_literal27_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:341:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:341:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR26=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1427); 
            		PARAM_COLOR26_tree = (object)adaptor.Create(PARAM_COLOR26);
            		adaptor.AddChild(root_0, PARAM_COLOR26_tree);

            	char_literal27=(IToken)Match(input,64,FOLLOW_64_in_color_param1429); 
            		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1433); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:344:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
    public GbsParser.scrolling_param_return scrolling_param() // throws RecognitionException [1]
    {   
        GbsParser.scrolling_param_return retval = new GbsParser.scrolling_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken dir = null;
        IToken speed = null;
        IToken PARAM_SCROLLING28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;

        object dir_tree=null;
        object speed_tree=null;
        object PARAM_SCROLLING28_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING28=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1451); 
            		PARAM_SCROLLING28_tree = (object)adaptor.Create(PARAM_SCROLLING28);
            		adaptor.AddChild(root_0, PARAM_SCROLLING28_tree);

            	char_literal29=(IToken)Match(input,64,FOLLOW_64_in_scrolling_param1453); 
            		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		adaptor.AddChild(root_0, char_literal29_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1457); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal30=(IToken)Match(input,65,FOLLOW_65_in_scrolling_param1459); 
            		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		adaptor.AddChild(root_0, char_literal30_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1463); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:348:1: classdef returns [Classdef en] : (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:359:2: (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef )
            int alt8 = 7;
            switch ( input.LA(1) ) 
            {
            case CLASSDEF_ENGINE:
            	{
                alt8 = 1;
                }
                break;
            case CLASSDEF_PLAYER:
            	{
                alt8 = 2;
                }
                break;
            case CLASSDEF_BULLET:
            	{
                alt8 = 3;
                }
                break;
            case CLASSDEF_ENEMY:
            	{
                alt8 = 4;
                }
                break;
            case CLASSDEF_EVENT:
            	{
                alt8 = 5;
                }
                break;
            case CLASSDEF_STATE:
            	{
                alt8 = 6;
                }
                break;
            case CLASSDEF_SCRIPT:
            	{
                alt8 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:359:4: ee= engine_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_classdef_in_classdef1494);
                    	ee = engine_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:4: pe= player_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_classdef_in_classdef1503);
                    	pe = player_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:361:4: be= bullet_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_classdef_in_classdef1512);
                    	be = bullet_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:362:4: ene= enemy_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_classdef_in_classdef1521);
                    	ene = enemy_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:363:4: eve= event_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_classdef_in_classdef1530);
                    	eve = event_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:4: ste= state_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_classdef_in_classdef1539);
                    	ste = state_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:365:4: se= script_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_classdef_in_classdef1548);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:1: classdef_content : (t= trigger | se= classdef );
    public GbsParser.classdef_content_return classdef_content() // throws RecognitionException [1]
    {   
        GbsParser.classdef_content_return retval = new GbsParser.classdef_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.classdef_return se = default(GbsParser.classdef_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:2: (t= trigger | se= classdef )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( ((LA9_0 >= TRIGGER_INIT && LA9_0 <= TRIGGER_EVENT)) )
            {
                alt9 = 1;
            }
            else if ( ((LA9_0 >= CLASSDEF_ENGINE && LA9_0 <= CLASSDEF_EVENT)) )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_classdef_content1563);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:370:4: se= classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classdef_in_classdef_content1579);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:373:1: engine_classdef returns [Classdef en] : CLASSDEF_ENGINE '{' ( classdef_content )* '}' ;
    public GbsParser.engine_classdef_return engine_classdef() // throws RecognitionException [1]
    {   
        GbsParser.engine_classdef_return retval = new GbsParser.engine_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASSDEF_ENGINE31 = null;
        IToken char_literal32 = null;
        IToken char_literal34 = null;
        GbsParser.classdef_content_return classdef_content33 = default(GbsParser.classdef_content_return);


        object CLASSDEF_ENGINE31_tree=null;
        object char_literal32_tree=null;
        object char_literal34_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:374:2: ( CLASSDEF_ENGINE '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:374:4: CLASSDEF_ENGINE '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENGINE31=(IToken)Match(input,CLASSDEF_ENGINE,FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1604); 
            		CLASSDEF_ENGINE31_tree = (object)adaptor.Create(CLASSDEF_ENGINE31);
            		adaptor.AddChild(root_0, CLASSDEF_ENGINE31_tree);

            	char_literal32=(IToken)Match(input,66,FOLLOW_66_in_engine_classdef1606); 
            		char_literal32_tree = (object)adaptor.Create(char_literal32);
            		adaptor.AddChild(root_0, char_literal32_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:374:24: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:374:24: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_engine_classdef1608);
            			    	classdef_content33 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content33.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal34=(IToken)Match(input,67,FOLLOW_67_in_engine_classdef1611); 
            		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:1: player_classdef returns [Classdef en] : CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.player_classdef_return player_classdef() // throws RecognitionException [1]
    {   
        GbsParser.player_classdef_return retval = new GbsParser.player_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_PLAYER35 = null;
        IToken char_literal36 = null;
        IToken char_literal38 = null;
        GbsParser.classdef_content_return classdef_content37 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_PLAYER35_tree=null;
        object char_literal36_tree=null;
        object char_literal38_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:378:2: ( CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:378:4: CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_PLAYER35=(IToken)Match(input,CLASSDEF_PLAYER,FOLLOW_CLASSDEF_PLAYER_in_player_classdef1629); 
            		CLASSDEF_PLAYER35_tree = (object)adaptor.Create(CLASSDEF_PLAYER35);
            		adaptor.AddChild(root_0, CLASSDEF_PLAYER35_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_classdef1633); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal36=(IToken)Match(input,66,FOLLOW_66_in_player_classdef1635); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:378:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:378:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_player_classdef1637);
            			    	classdef_content37 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal38=(IToken)Match(input,67,FOLLOW_67_in_player_classdef1640); 
            		char_literal38_tree = (object)adaptor.Create(char_literal38);
            		adaptor.AddChild(root_0, char_literal38_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:381:1: enemy_classdef returns [Classdef en] : CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.enemy_classdef_return enemy_classdef() // throws RecognitionException [1]
    {   
        GbsParser.enemy_classdef_return retval = new GbsParser.enemy_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_ENEMY39 = null;
        IToken char_literal40 = null;
        IToken char_literal42 = null;
        GbsParser.classdef_content_return classdef_content41 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_ENEMY39_tree=null;
        object char_literal40_tree=null;
        object char_literal42_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:382:2: ( CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:382:4: CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENEMY39=(IToken)Match(input,CLASSDEF_ENEMY,FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1657); 
            		CLASSDEF_ENEMY39_tree = (object)adaptor.Create(CLASSDEF_ENEMY39);
            		adaptor.AddChild(root_0, CLASSDEF_ENEMY39_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1661); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal40=(IToken)Match(input,66,FOLLOW_66_in_enemy_classdef1663); 
            		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		adaptor.AddChild(root_0, char_literal40_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:382:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:382:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_enemy_classdef1665);
            			    	classdef_content41 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal42=(IToken)Match(input,67,FOLLOW_67_in_enemy_classdef1668); 
            		char_literal42_tree = (object)adaptor.Create(char_literal42);
            		adaptor.AddChild(root_0, char_literal42_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:385:1: bullet_classdef returns [Classdef en] : CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.bullet_classdef_return bullet_classdef() // throws RecognitionException [1]
    {   
        GbsParser.bullet_classdef_return retval = new GbsParser.bullet_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_BULLET43 = null;
        IToken char_literal44 = null;
        IToken char_literal46 = null;
        GbsParser.classdef_content_return classdef_content45 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_BULLET43_tree=null;
        object char_literal44_tree=null;
        object char_literal46_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:386:2: ( CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:386:4: CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_BULLET43=(IToken)Match(input,CLASSDEF_BULLET,FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1685); 
            		CLASSDEF_BULLET43_tree = (object)adaptor.Create(CLASSDEF_BULLET43);
            		adaptor.AddChild(root_0, CLASSDEF_BULLET43_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1689); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal44=(IToken)Match(input,66,FOLLOW_66_in_bullet_classdef1691); 
            		char_literal44_tree = (object)adaptor.Create(char_literal44);
            		adaptor.AddChild(root_0, char_literal44_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:386:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:386:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_bullet_classdef1693);
            			    	classdef_content45 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content45.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	char_literal46=(IToken)Match(input,67,FOLLOW_67_in_bullet_classdef1696); 
            		char_literal46_tree = (object)adaptor.Create(char_literal46);
            		adaptor.AddChild(root_0, char_literal46_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:389:1: script_classdef returns [Classdef en] : CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.script_classdef_return script_classdef() // throws RecognitionException [1]
    {   
        GbsParser.script_classdef_return retval = new GbsParser.script_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_SCRIPT47 = null;
        IToken char_literal48 = null;
        IToken char_literal50 = null;
        GbsParser.classdef_content_return classdef_content49 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_SCRIPT47_tree=null;
        object char_literal48_tree=null;
        object char_literal50_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:2: ( CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:4: CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_SCRIPT47=(IToken)Match(input,CLASSDEF_SCRIPT,FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1714); 
            		CLASSDEF_SCRIPT47_tree = (object)adaptor.Create(CLASSDEF_SCRIPT47);
            		adaptor.AddChild(root_0, CLASSDEF_SCRIPT47_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_classdef1718); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal48=(IToken)Match(input,66,FOLLOW_66_in_script_classdef1720); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:46: ( classdef_content )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= CLASSDEF_ENGINE && LA14_0 <= CLASSDEF_EVENT) || (LA14_0 >= TRIGGER_INIT && LA14_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:390:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_script_classdef1722);
            			    	classdef_content49 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content49.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	char_literal50=(IToken)Match(input,67,FOLLOW_67_in_script_classdef1725); 
            		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		adaptor.AddChild(root_0, char_literal50_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:393:1: state_classdef returns [Classdef en] : CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.state_classdef_return state_classdef() // throws RecognitionException [1]
    {   
        GbsParser.state_classdef_return retval = new GbsParser.state_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_STATE51 = null;
        IToken char_literal52 = null;
        IToken char_literal54 = null;
        GbsParser.classdef_content_return classdef_content53 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_STATE51_tree=null;
        object char_literal52_tree=null;
        object char_literal54_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:2: ( CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:4: CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_STATE51=(IToken)Match(input,CLASSDEF_STATE,FOLLOW_CLASSDEF_STATE_in_state_classdef1742); 
            		CLASSDEF_STATE51_tree = (object)adaptor.Create(CLASSDEF_STATE51);
            		adaptor.AddChild(root_0, CLASSDEF_STATE51_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_classdef1746); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal52=(IToken)Match(input,66,FOLLOW_66_in_state_classdef1748); 
            		char_literal52_tree = (object)adaptor.Create(char_literal52);
            		adaptor.AddChild(root_0, char_literal52_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:45: ( classdef_content )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= CLASSDEF_ENGINE && LA15_0 <= CLASSDEF_EVENT) || (LA15_0 >= TRIGGER_INIT && LA15_0 <= TRIGGER_EVENT)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_state_classdef1750);
            			    	classdef_content53 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	char_literal54=(IToken)Match(input,67,FOLLOW_67_in_state_classdef1753); 
            		char_literal54_tree = (object)adaptor.Create(char_literal54);
            		adaptor.AddChild(root_0, char_literal54_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:397:1: event_classdef returns [Classdef en] : CLASSDEF_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_classdef_return event_classdef() // throws RecognitionException [1]
    {   
        GbsParser.event_classdef_return retval = new GbsParser.event_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_EVENT55 = null;

        object name_tree=null;
        object CLASSDEF_EVENT55_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:398:2: ( CLASSDEF_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:398:4: CLASSDEF_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_EVENT55=(IToken)Match(input,CLASSDEF_EVENT,FOLLOW_CLASSDEF_EVENT_in_event_classdef1772); 
            		CLASSDEF_EVENT55_tree = (object)adaptor.Create(CLASSDEF_EVENT55);
            		adaptor.AddChild(root_0, CLASSDEF_EVENT55_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_classdef1776); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:401:1: action_list returns [List<Action> actions] : ( action )* ;
    public GbsParser.action_list_return action_list() // throws RecognitionException [1]
    {   
        action_list_stack.Push(new action_list_scope());
        GbsParser.action_list_return retval = new GbsParser.action_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.action_return action56 = default(GbsParser.action_return);



         
        	((action_list_scope)action_list_stack.Peek()).list =  new List<Action>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:4: ( action )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == THIS || (LA16_0 >= PARAM_FPS && LA16_0 <= ACTION_RAISE) || LA16_0 == INSTANCE_IDENTIFIER) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1805);
            			    	action56 = action();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, action56.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:413:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
    public GbsParser.action_target_return action_target() // throws RecognitionException [1]
    {   
        GbsParser.action_target_return retval = new GbsParser.action_target_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ident = null;
        IToken THIS57 = null;

        object ident_tree=null;
        object THIS57_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == THIS || (LA18_0 >= ACTION_PERIODIC && LA18_0 <= ACTION_RAISE)) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == INSTANCE_IDENTIFIER) )
            {
                alt18 = 2;
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:4: ( THIS )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == THIS) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:4: THIS
                    	        {
                    	        	THIS57=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target1823); 
                    	        		THIS57_tree = (object)adaptor.Create(THIS57);
                    	        		adaptor.AddChild(root_0, THIS57_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:415:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target1853); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:418:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );
    public GbsParser.action_return action() // throws RecognitionException [1]
    {   
        GbsParser.action_return retval = new GbsParser.action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.play_animation_action_return pla = default(GbsParser.play_animation_action_return);

        GbsParser.periodic_action_return pa = default(GbsParser.periodic_action_return);

        GbsParser.fire_action_return fap = default(GbsParser.fire_action_return);

        GbsParser.fire_multiple_action_return fam = default(GbsParser.fire_multiple_action_return);

        GbsParser.die_action_return da = default(GbsParser.die_action_return);

        GbsParser.start_action_return sta = default(GbsParser.start_action_return);

        GbsParser.stop_action_return sa = default(GbsParser.stop_action_return);

        GbsParser.summon_action_return sum = default(GbsParser.summon_action_return);

        GbsParser.set_action_return sea = default(GbsParser.set_action_return);

        GbsParser.raise_action_return raa = default(GbsParser.raise_action_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:419:2: (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action )
            int alt19 = 10;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:419:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action1868);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:420:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action1877);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:4: fap= fire_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_action_in_action1893);
                    	fap = fire_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:422:4: fam= fire_multiple_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_multiple_action_in_action1907);
                    	fam = fire_multiple_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fam.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fam != null) ? fam.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:423:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action1917);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:424:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action1938);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action1956);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action1976);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:427:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action1993);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

                    }
                    break;
                case 10 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:428:4: raa= raise_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_raise_action_in_action2013);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:431:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
    public GbsParser.play_animation_action_return play_animation_action() // throws RecognitionException [1]
    {   
        GbsParser.play_animation_action_return retval = new GbsParser.play_animation_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken ACTION_PLAY_ANIMATION58 = null;
        IToken char_literal59 = null;
        IToken char_literal60 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object anim_tree=null;
        object ACTION_PLAY_ANIMATION58_tree=null;
        object char_literal59_tree=null;
        object char_literal60_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:432:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:432:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action2035);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION58=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action2037); 
            		ACTION_PLAY_ANIMATION58_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION58);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION58_tree);

            	char_literal59=(IToken)Match(input,61,FOLLOW_61_in_play_animation_action2039); 
            		char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action2043); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal60=(IToken)Match(input,62,FOLLOW_62_in_play_animation_action2045); 
            		char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:435:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken period = null;
        IToken ACTION_PERIODIC61 = null;
        IToken char_literal62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object period_tree=null;
        object ACTION_PERIODIC61_tree=null;
        object char_literal62_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:436:2: (target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:436:4: target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action2065);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC61=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action2067); 
            		ACTION_PERIODIC61_tree = (object)adaptor.Create(ACTION_PERIODIC61);
            		adaptor.AddChild(root_0, ACTION_PERIODIC61_tree);

            	char_literal62=(IToken)Match(input,61,FOLLOW_61_in_periodic_action2069); 
            		char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);

            	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action2073); 
            		period_tree = (object)adaptor.Create(period);
            		adaptor.AddChild(root_0, period_tree);

            	char_literal63=(IToken)Match(input,62,FOLLOW_62_in_periodic_action2075); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

            	char_literal64=(IToken)Match(input,66,FOLLOW_66_in_periodic_action2077); 
            		char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action2081);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal65=(IToken)Match(input,67,FOLLOW_67_in_periodic_action2083); 
            		char_literal65_tree = (object)adaptor.Create(char_literal65);
            		adaptor.AddChild(root_0, char_literal65_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:439:1: fire_action returns [Action action] : target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' ;
    public GbsParser.fire_action_return fire_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_action_return retval = new GbsParser.fire_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE66 = null;
        IToken char_literal67 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return angle = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE66_tree=null;
        object char_literal67_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:440:2: (target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:440:4: target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_action2103);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE66=(IToken)Match(input,ACTION_FIRE,FOLLOW_ACTION_FIRE_in_fire_action2105); 
            		ACTION_FIRE66_tree = (object)adaptor.Create(ACTION_FIRE66);
            		adaptor.AddChild(root_0, ACTION_FIRE66_tree);

            	char_literal67=(IToken)Match(input,61,FOLLOW_61_in_fire_action2107); 
            		char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_action2111); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal68=(IToken)Match(input,65,FOLLOW_65_in_fire_action2113); 
            		char_literal68_tree = (object)adaptor.Create(char_literal68);
            		adaptor.AddChild(root_0, char_literal68_tree);

            	PushFollow(FOLLOW_formula_in_fire_action2117);
            	angle = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, angle.Tree);
            	char_literal69=(IToken)Match(input,62,FOLLOW_62_in_fire_action2119); 
            		char_literal69_tree = (object)adaptor.Create(char_literal69);
            		adaptor.AddChild(root_0, char_literal69_tree);

            	 retval.action =  new FireAction(((target != null) ? target.target : default(String)), bullet.Text, ((angle != null) ? angle.f : default(Formula))); 

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

    public class fire_multiple_action_return : ParserRuleReturnScope
    {
        public Action action;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fire_multiple_action"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:443:1: fire_multiple_action returns [Action action] : target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')' ;
    public GbsParser.fire_multiple_action_return fire_multiple_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_multiple_action_return retval = new GbsParser.fire_multiple_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE_MULTIPLE70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return baseDir = default(GbsParser.formula_return);

        GbsParser.range_return r = default(GbsParser.range_return);

        GbsParser.formula_return increment = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE_MULTIPLE70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:444:2: (target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:444:4: target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_multiple_action2138);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE_MULTIPLE70=(IToken)Match(input,ACTION_FIRE_MULTIPLE,FOLLOW_ACTION_FIRE_MULTIPLE_in_fire_multiple_action2140); 
            		ACTION_FIRE_MULTIPLE70_tree = (object)adaptor.Create(ACTION_FIRE_MULTIPLE70);
            		adaptor.AddChild(root_0, ACTION_FIRE_MULTIPLE70_tree);

            	char_literal71=(IToken)Match(input,61,FOLLOW_61_in_fire_multiple_action2142); 
            		char_literal71_tree = (object)adaptor.Create(char_literal71);
            		adaptor.AddChild(root_0, char_literal71_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_multiple_action2146); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal72=(IToken)Match(input,65,FOLLOW_65_in_fire_multiple_action2148); 
            		char_literal72_tree = (object)adaptor.Create(char_literal72);
            		adaptor.AddChild(root_0, char_literal72_tree);

            	PushFollow(FOLLOW_formula_in_fire_multiple_action2152);
            	baseDir = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, baseDir.Tree);
            	char_literal73=(IToken)Match(input,65,FOLLOW_65_in_fire_multiple_action2154); 
            		char_literal73_tree = (object)adaptor.Create(char_literal73);
            		adaptor.AddChild(root_0, char_literal73_tree);

            	PushFollow(FOLLOW_range_in_fire_multiple_action2158);
            	r = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r.Tree);
            	char_literal74=(IToken)Match(input,65,FOLLOW_65_in_fire_multiple_action2160); 
            		char_literal74_tree = (object)adaptor.Create(char_literal74);
            		adaptor.AddChild(root_0, char_literal74_tree);

            	PushFollow(FOLLOW_formula_in_fire_multiple_action2164);
            	increment = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, increment.Tree);
            	char_literal75=(IToken)Match(input,62,FOLLOW_62_in_fire_multiple_action2166); 
            		char_literal75_tree = (object)adaptor.Create(char_literal75);
            		adaptor.AddChild(root_0, char_literal75_tree);

            	 retval.action =  new FireMultipleAction(((target != null) ? target.target : default(String)), bullet.Text, ((baseDir != null) ? baseDir.f : default(Formula)), ((r != null) ? r.range : default(Range)), ((increment != null) ? increment.f : default(Formula))); 

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
    // $ANTLR end "fire_multiple_action"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:447:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE76 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE76_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:448:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:448:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action2186);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE76=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action2188); 
            		ACTION_DIE76_tree = (object)adaptor.Create(ACTION_DIE76);
            		adaptor.AddChild(root_0, ACTION_DIE76_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:451:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START77 = null;
        IToken char_literal78 = null;
        IToken char_literal79 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START77_tree=null;
        object char_literal78_tree=null;
        object char_literal79_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:452:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:452:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action2208);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START77=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action2210); 
            		ACTION_START77_tree = (object)adaptor.Create(ACTION_START77);
            		adaptor.AddChild(root_0, ACTION_START77_tree);

            	char_literal78=(IToken)Match(input,61,FOLLOW_61_in_start_action2212); 
            		char_literal78_tree = (object)adaptor.Create(char_literal78);
            		adaptor.AddChild(root_0, char_literal78_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action2216); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal79=(IToken)Match(input,62,FOLLOW_62_in_start_action2218); 
            		char_literal79_tree = (object)adaptor.Create(char_literal79);
            		adaptor.AddChild(root_0, char_literal79_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:455:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP80 = null;
        IToken char_literal81 = null;
        IToken char_literal82 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP80_tree=null;
        object char_literal81_tree=null;
        object char_literal82_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:456:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:456:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action2237);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP80=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action2239); 
            		ACTION_STOP80_tree = (object)adaptor.Create(ACTION_STOP80);
            		adaptor.AddChild(root_0, ACTION_STOP80_tree);

            	char_literal81=(IToken)Match(input,61,FOLLOW_61_in_stop_action2241); 
            		char_literal81_tree = (object)adaptor.Create(char_literal81);
            		adaptor.AddChild(root_0, char_literal81_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action2245); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal82=(IToken)Match(input,62,FOLLOW_62_in_stop_action2247); 
            		char_literal82_tree = (object)adaptor.Create(char_literal82);
            		adaptor.AddChild(root_0, char_literal82_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:459:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON83 = null;
        IToken char_literal84 = null;
        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken char_literal87 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON83_tree=null;
        object char_literal84_tree=null;
        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object char_literal87_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:460:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:460:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action2268);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON83=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action2270); 
            		ACTION_SUMMON83_tree = (object)adaptor.Create(ACTION_SUMMON83);
            		adaptor.AddChild(root_0, ACTION_SUMMON83_tree);

            	char_literal84=(IToken)Match(input,61,FOLLOW_61_in_summon_action2272); 
            		char_literal84_tree = (object)adaptor.Create(char_literal84);
            		adaptor.AddChild(root_0, char_literal84_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action2276); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal85=(IToken)Match(input,62,FOLLOW_62_in_summon_action2278); 
            		char_literal85_tree = (object)adaptor.Create(char_literal85);
            		adaptor.AddChild(root_0, char_literal85_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2282); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:460:95: ( '{' a= action_list '}' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 66) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:460:97: '{' a= action_list '}'
            	        {
            	        	char_literal86=(IToken)Match(input,66,FOLLOW_66_in_summon_action2286); 
            	        		char_literal86_tree = (object)adaptor.Create(char_literal86);
            	        		adaptor.AddChild(root_0, char_literal86_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action2290);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal87=(IToken)Match(input,67,FOLLOW_67_in_summon_action2292); 
            	        		char_literal87_tree = (object)adaptor.Create(char_literal87);
            	        		adaptor.AddChild(root_0, char_literal87_tree);


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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:463:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET88 = null;
        IToken char_literal89 = null;
        IToken char_literal90 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET88_tree=null;
        object char_literal89_tree=null;
        object char_literal90_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:464:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( (LA21_0 == THIS || (LA21_0 >= ACTION_PERIODIC && LA21_0 <= ACTION_RAISE) || LA21_0 == INSTANCE_IDENTIFIER) )
            {
                alt21 = 1;
            }
            else if ( ((LA21_0 >= PARAM_FPS && LA21_0 <= PARAM_SCROLLING)) )
            {
                alt21 = 2;
            }
            else 
            {
                NoViableAltException nvae_d21s0 =
                    new NoViableAltException("", 21, 0, input);

                throw nvae_d21s0;
            }
            switch (alt21) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:464:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action2315);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET88=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action2317); 
                    		ACTION_SET88_tree = (object)adaptor.Create(ACTION_SET88);
                    		adaptor.AddChild(root_0, ACTION_SET88_tree);

                    	char_literal89=(IToken)Match(input,61,FOLLOW_61_in_set_action2319); 
                    		char_literal89_tree = (object)adaptor.Create(char_literal89);
                    		adaptor.AddChild(root_0, char_literal89_tree);

                    	PushFollow(FOLLOW_param_in_set_action2323);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal90=(IToken)Match(input,62,FOLLOW_62_in_set_action2325); 
                    		char_literal90_tree = (object)adaptor.Create(char_literal90);
                    		adaptor.AddChild(root_0, char_literal90_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:465:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action2334);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:468:1: raise_action returns [Action action] : target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' ;
    public GbsParser.raise_action_return raise_action() // throws RecognitionException [1]
    {   
        GbsParser.raise_action_return retval = new GbsParser.raise_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e = null;
        IToken ACTION_RAISE91 = null;
        IToken char_literal92 = null;
        IToken char_literal93 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object e_tree=null;
        object ACTION_RAISE91_tree=null;
        object char_literal92_tree=null;
        object char_literal93_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:469:2: (target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:469:4: target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_raise_action2394);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_RAISE91=(IToken)Match(input,ACTION_RAISE,FOLLOW_ACTION_RAISE_in_raise_action2396); 
            		ACTION_RAISE91_tree = (object)adaptor.Create(ACTION_RAISE91);
            		adaptor.AddChild(root_0, ACTION_RAISE91_tree);

            	char_literal92=(IToken)Match(input,61,FOLLOW_61_in_raise_action2398); 
            		char_literal92_tree = (object)adaptor.Create(char_literal92);
            		adaptor.AddChild(root_0, char_literal92_tree);

            	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_raise_action2402); 
            		e_tree = (object)adaptor.Create(e);
            		adaptor.AddChild(root_0, e_tree);

            	char_literal93=(IToken)Match(input,62,FOLLOW_62_in_raise_action2404); 
            		char_literal93_tree = (object)adaptor.Create(char_literal93);
            		adaptor.AddChild(root_0, char_literal93_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:472:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
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
        IToken TRIGGER_INIT94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        IToken TRIGGER_CLEANUP97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        IToken TRIGGER_TIME100 = null;
        IToken char_literal101 = null;
        IToken char_literal102 = null;
        IToken char_literal103 = null;
        IToken char_literal104 = null;
        IToken TRIGGER_PERIODIC105 = null;
        IToken char_literal106 = null;
        IToken char_literal107 = null;
        IToken char_literal108 = null;
        IToken char_literal109 = null;
        IToken TRIGGER_SCROLLING110 = null;
        IToken char_literal111 = null;
        IToken char_literal112 = null;
        IToken char_literal113 = null;
        IToken char_literal114 = null;
        IToken TRIGGER_ANIMATION_END115 = null;
        IToken char_literal116 = null;
        IToken char_literal117 = null;
        IToken char_literal118 = null;
        IToken char_literal119 = null;
        IToken TRIGGER_EVENT120 = null;
        IToken char_literal121 = null;
        IToken char_literal122 = null;
        IToken char_literal123 = null;
        IToken char_literal124 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object period_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;
        object TRIGGER_CLEANUP97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;
        object TRIGGER_TIME100_tree=null;
        object char_literal101_tree=null;
        object char_literal102_tree=null;
        object char_literal103_tree=null;
        object char_literal104_tree=null;
        object TRIGGER_PERIODIC105_tree=null;
        object char_literal106_tree=null;
        object char_literal107_tree=null;
        object char_literal108_tree=null;
        object char_literal109_tree=null;
        object TRIGGER_SCROLLING110_tree=null;
        object char_literal111_tree=null;
        object char_literal112_tree=null;
        object char_literal113_tree=null;
        object char_literal114_tree=null;
        object TRIGGER_ANIMATION_END115_tree=null;
        object char_literal116_tree=null;
        object char_literal117_tree=null;
        object char_literal118_tree=null;
        object char_literal119_tree=null;
        object TRIGGER_EVENT120_tree=null;
        object char_literal121_tree=null;
        object char_literal122_tree=null;
        object char_literal123_tree=null;
        object char_literal124_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:473:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
            int alt22 = 7;
            switch ( input.LA(1) ) 
            {
            case TRIGGER_INIT:
            	{
                alt22 = 1;
                }
                break;
            case TRIGGER_CLEANUP:
            	{
                alt22 = 2;
                }
                break;
            case TRIGGER_TIME:
            	{
                alt22 = 3;
                }
                break;
            case TRIGGER_PERIODIC:
            	{
                alt22 = 4;
                }
                break;
            case TRIGGER_SCROLLING:
            	{
                alt22 = 5;
                }
                break;
            case TRIGGER_ANIMATION_END:
            	{
                alt22 = 6;
                }
                break;
            case TRIGGER_EVENT:
            	{
                alt22 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:473:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT94=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger2422); 
                    		TRIGGER_INIT94_tree = (object)adaptor.Create(TRIGGER_INIT94);
                    		adaptor.AddChild(root_0, TRIGGER_INIT94_tree);

                    	char_literal95=(IToken)Match(input,66,FOLLOW_66_in_trigger2424); 
                    		char_literal95_tree = (object)adaptor.Create(char_literal95);
                    		adaptor.AddChild(root_0, char_literal95_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2428);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal96=(IToken)Match(input,67,FOLLOW_67_in_trigger2430); 
                    		char_literal96_tree = (object)adaptor.Create(char_literal96);
                    		adaptor.AddChild(root_0, char_literal96_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:474:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP97=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2466); 
                    		TRIGGER_CLEANUP97_tree = (object)adaptor.Create(TRIGGER_CLEANUP97);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP97_tree);

                    	char_literal98=(IToken)Match(input,66,FOLLOW_66_in_trigger2468); 
                    		char_literal98_tree = (object)adaptor.Create(char_literal98);
                    		adaptor.AddChild(root_0, char_literal98_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2472);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal99=(IToken)Match(input,67,FOLLOW_67_in_trigger2474); 
                    		char_literal99_tree = (object)adaptor.Create(char_literal99);
                    		adaptor.AddChild(root_0, char_literal99_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:475:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME100=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2507); 
                    		TRIGGER_TIME100_tree = (object)adaptor.Create(TRIGGER_TIME100);
                    		adaptor.AddChild(root_0, TRIGGER_TIME100_tree);

                    	char_literal101=(IToken)Match(input,61,FOLLOW_61_in_trigger2509); 
                    		char_literal101_tree = (object)adaptor.Create(char_literal101);
                    		adaptor.AddChild(root_0, char_literal101_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2513); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal102=(IToken)Match(input,62,FOLLOW_62_in_trigger2515); 
                    		char_literal102_tree = (object)adaptor.Create(char_literal102);
                    		adaptor.AddChild(root_0, char_literal102_tree);

                    	char_literal103=(IToken)Match(input,66,FOLLOW_66_in_trigger2517); 
                    		char_literal103_tree = (object)adaptor.Create(char_literal103);
                    		adaptor.AddChild(root_0, char_literal103_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2521);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal104=(IToken)Match(input,67,FOLLOW_67_in_trigger2523); 
                    		char_literal104_tree = (object)adaptor.Create(char_literal104);
                    		adaptor.AddChild(root_0, char_literal104_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:476:4: TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_PERIODIC105=(IToken)Match(input,TRIGGER_PERIODIC,FOLLOW_TRIGGER_PERIODIC_in_trigger2539); 
                    		TRIGGER_PERIODIC105_tree = (object)adaptor.Create(TRIGGER_PERIODIC105);
                    		adaptor.AddChild(root_0, TRIGGER_PERIODIC105_tree);

                    	char_literal106=(IToken)Match(input,61,FOLLOW_61_in_trigger2541); 
                    		char_literal106_tree = (object)adaptor.Create(char_literal106);
                    		adaptor.AddChild(root_0, char_literal106_tree);

                    	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2545); 
                    		period_tree = (object)adaptor.Create(period);
                    		adaptor.AddChild(root_0, period_tree);

                    	char_literal107=(IToken)Match(input,62,FOLLOW_62_in_trigger2547); 
                    		char_literal107_tree = (object)adaptor.Create(char_literal107);
                    		adaptor.AddChild(root_0, char_literal107_tree);

                    	char_literal108=(IToken)Match(input,66,FOLLOW_66_in_trigger2549); 
                    		char_literal108_tree = (object)adaptor.Create(char_literal108);
                    		adaptor.AddChild(root_0, char_literal108_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2553);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal109=(IToken)Match(input,67,FOLLOW_67_in_trigger2555); 
                    		char_literal109_tree = (object)adaptor.Create(char_literal109);
                    		adaptor.AddChild(root_0, char_literal109_tree);

                    	 retval.t =  new PeriodicTrigger(float.Parse(period.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:477:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING110=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2562); 
                    		TRIGGER_SCROLLING110_tree = (object)adaptor.Create(TRIGGER_SCROLLING110);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING110_tree);

                    	char_literal111=(IToken)Match(input,61,FOLLOW_61_in_trigger2564); 
                    		char_literal111_tree = (object)adaptor.Create(char_literal111);
                    		adaptor.AddChild(root_0, char_literal111_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2568); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal112=(IToken)Match(input,62,FOLLOW_62_in_trigger2570); 
                    		char_literal112_tree = (object)adaptor.Create(char_literal112);
                    		adaptor.AddChild(root_0, char_literal112_tree);

                    	char_literal113=(IToken)Match(input,66,FOLLOW_66_in_trigger2572); 
                    		char_literal113_tree = (object)adaptor.Create(char_literal113);
                    		adaptor.AddChild(root_0, char_literal113_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2576);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal114=(IToken)Match(input,67,FOLLOW_67_in_trigger2578); 
                    		char_literal114_tree = (object)adaptor.Create(char_literal114);
                    		adaptor.AddChild(root_0, char_literal114_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:478:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END115=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2587); 
                    		TRIGGER_ANIMATION_END115_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END115);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END115_tree);

                    	char_literal116=(IToken)Match(input,61,FOLLOW_61_in_trigger2589); 
                    		char_literal116_tree = (object)adaptor.Create(char_literal116);
                    		adaptor.AddChild(root_0, char_literal116_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2593); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal117=(IToken)Match(input,62,FOLLOW_62_in_trigger2595); 
                    		char_literal117_tree = (object)adaptor.Create(char_literal117);
                    		adaptor.AddChild(root_0, char_literal117_tree);

                    	char_literal118=(IToken)Match(input,66,FOLLOW_66_in_trigger2597); 
                    		char_literal118_tree = (object)adaptor.Create(char_literal118);
                    		adaptor.AddChild(root_0, char_literal118_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2601);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal119=(IToken)Match(input,67,FOLLOW_67_in_trigger2603); 
                    		char_literal119_tree = (object)adaptor.Create(char_literal119);
                    		adaptor.AddChild(root_0, char_literal119_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:479:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT120=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2610); 
                    		TRIGGER_EVENT120_tree = (object)adaptor.Create(TRIGGER_EVENT120);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT120_tree);

                    	char_literal121=(IToken)Match(input,61,FOLLOW_61_in_trigger2612); 
                    		char_literal121_tree = (object)adaptor.Create(char_literal121);
                    		adaptor.AddChild(root_0, char_literal121_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2616); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal122=(IToken)Match(input,62,FOLLOW_62_in_trigger2618); 
                    		char_literal122_tree = (object)adaptor.Create(char_literal122);
                    		adaptor.AddChild(root_0, char_literal122_tree);

                    	char_literal123=(IToken)Match(input,66,FOLLOW_66_in_trigger2620); 
                    		char_literal123_tree = (object)adaptor.Create(char_literal123);
                    		adaptor.AddChild(root_0, char_literal123_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2624);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal124=(IToken)Match(input,67,FOLLOW_67_in_trigger2626); 
                    		char_literal124_tree = (object)adaptor.Create(char_literal124);
                    		adaptor.AddChild(root_0, char_literal124_tree);

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


   	protected DFA6 dfa6;
   	protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa19 = new DFA19(this);


	}

    const string DFA6_eotS =
        "\x0b\uffff";
    const string DFA6_eofS =
        "\x0b\uffff";
    const string DFA6_minS =
        "\x01\x24\x01\x38\x09\uffff";
    const string DFA6_maxS =
        "\x01\x3d\x01\x41\x09\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01"+
        "\x09\x01\x02\x01\x01";
    const string DFA6_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x06\x01\x07\x01\x02\x01\x03\x01\x04\x01\x05\x03\uffff"+
            "\x01\x01\x0f\uffff\x01\x08",
            "\x04\x0a\x01\x09\x01\uffff\x01\x0a\x02\uffff\x01\x0a",
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

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "294:1: simple_formula returns [Formula f] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | '(' sf= formula ')' );"; }
        }

    }

    const string DFA19_eotS =
        "\x0d\uffff";
    const string DFA19_eofS =
        "\x0d\uffff";
    const string DFA19_minS =
        "\x01\x04\x01\x13\x01\uffff\x01\x13\x09\uffff";
    const string DFA19_maxS =
        "\x01\x33\x01\x1c\x01\uffff\x01\x1c\x09\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a";
    const string DFA19_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x01\x07\uffff\x07\x0b\x01\x04\x01\x05\x01\x06\x01\x07"+
            "\x01\x08\x01\x09\x01\x0a\x01\x02\x01\x0b\x01\x0c\x16\uffff\x01"+
            "\x03",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01"+
            "\x02\x01\x0b\x01\x0c",
            "",
            "\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01"+
            "\x02\x01\x0b\x01\x0c",
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

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "418:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_classdef_in_gbs971 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula1003 = new BitSet(new ulong[]{0x0300000000000002UL});
    public static readonly BitSet FOLLOW_56_in_formula1009 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_57_in_formula1015 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula1023 = new BitSet(new ulong[]{0x0300000000000002UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1060 = new BitSet(new ulong[]{0x0C00000000000002UL});
    public static readonly BitSet FOLLOW_58_in_factor_formula1066 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_59_in_factor_formula1072 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1080 = new BitSet(new ulong[]{0x0C00000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1113 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_simple_formula1115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_UP_in_simple_formula1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_CURRENT_in_simple_formula1157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_simple_formula1164 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_formula_in_simple_formula1168 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_simple_formula1170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_range1190 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_range1192 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_range1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fps_param_in_param1216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param1232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param1253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param1267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param1277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param1308 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_fps_param1310 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param1314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1331 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_gamearea_param1333 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1355 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_position_param1357 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1379 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_speed_param1381 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1403 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_animation_param1405 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1427 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_color_param1429 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1451 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_scrolling_param1453 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1457 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_scrolling_param1459 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_classdef_in_classdef1494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_classdef_in_classdef1503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_classdef_in_classdef1512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_classdef_in_classdef1521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_classdef_in_classdef1530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_classdef_in_classdef1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_classdef_in_classdef1548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_classdef_content1563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_classdef_content1579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1604 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_engine_classdef1606 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_engine_classdef1608 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_engine_classdef1611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_PLAYER_in_player_classdef1629 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_classdef1633 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_player_classdef1635 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_player_classdef1637 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_player_classdef1640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1657 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1661 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_enemy_classdef1663 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_enemy_classdef1665 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_enemy_classdef1668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1685 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1689 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_bullet_classdef1691 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_bullet_classdef1693 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_bullet_classdef1696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1714 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_classdef1718 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_script_classdef1720 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_script_classdef1722 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_script_classdef1725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_STATE_in_state_classdef1742 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_classdef1746 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_state_classdef1748 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classdef_content_in_state_classdef1750 = new BitSet(new ulong[]{0x0000000FE0000FE0UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_state_classdef1753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_EVENT_in_event_classdef1772 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_classdef1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1805 = new BitSet(new ulong[]{0x000800001FFFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target1823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target1853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action1868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action1877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_action_in_action1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_multiple_action_in_action1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action1917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action1938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action1956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action1976 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action1993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_raise_action_in_action2013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action2035 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action2037 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_play_animation_action2039 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action2043 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_play_animation_action2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action2065 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action2067 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_periodic_action2069 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action2073 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_periodic_action2075 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_periodic_action2077 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action2081 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_periodic_action2083 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_action2103 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_in_fire_action2105 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_fire_action2107 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_action2111 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_fire_action2113 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_action2117 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_fire_action2119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_multiple_action2138 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_MULTIPLE_in_fire_multiple_action2140 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_fire_multiple_action2142 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_multiple_action2146 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_fire_multiple_action2148 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_multiple_action2152 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_fire_multiple_action2154 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_range_in_fire_multiple_action2158 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_fire_multiple_action2160 = new BitSet(new ulong[]{0x200023F000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_multiple_action2164 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_fire_multiple_action2166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action2186 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action2188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action2208 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action2210 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_start_action2212 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action2216 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_start_action2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action2237 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action2239 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_stop_action2241 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action2245 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_stop_action2247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action2268 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action2270 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_summon_action2272 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action2276 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_summon_action2278 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2282 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_summon_action2286 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action2290 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_summon_action2292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action2315 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action2317 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_set_action2319 = new BitSet(new ulong[]{0x000800000807F010UL});
    public static readonly BitSet FOLLOW_param_in_set_action2323 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_set_action2325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_raise_action2394 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_ACTION_RAISE_in_raise_action2396 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_raise_action2398 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_raise_action2402 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_raise_action2404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger2422 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2424 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2428 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2466 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2468 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2507 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2509 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2513 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_trigger2515 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2517 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2521 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_PERIODIC_in_trigger2539 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2541 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2545 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_trigger2547 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2549 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2553 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2562 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2564 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2568 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_trigger2570 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2572 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2576 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2587 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2589 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2593 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_trigger2595 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2597 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2601 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2610 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2612 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2616 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_trigger2618 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_trigger2620 = new BitSet(new ulong[]{0x000800001FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2624 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_trigger2626 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}