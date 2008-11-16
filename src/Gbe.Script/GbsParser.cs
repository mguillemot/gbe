// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-11-16 21:50:55
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
using Gbe.Script.Shapedefs;


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
		"PARAM_TRAJECTORY", 
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
		"INSTANCE_IDENTIFIER", 
		"VARIABLE", 
		"SHAPE_CIRCLE", 
		"HEX_DIGIT", 
		"COLOR", 
		"CARDINAL_DIRECTION", 
		"NUMBER", 
		"DIRECTION", 
		"DIGIT", 
		"POINT", 
		"RECTANGLE", 
		"CLASS_IDENTIFIER", 
		"STRING", 
		"WHITESPACE", 
		"ML_COMMENT", 
		"SL_COMMENT", 
		"'('", 
		"','", 
		"')'", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'°'", 
		"'..'", 
		"'='", 
		"'{'", 
		"'}'"
    };

    public const int DIRECTION = 50;
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int CONST_ANGLE_RIGHT = 42;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int ACTION_SET = 28;
    public const int POINT = 52;
    public const int TRIGGER_SCROLLING = 34;
    public const int CLASSDEF_SCRIPT = 9;
    public const int CONST_ANGLE_UP = 40;
    public const int ACTION_FIRE_MULTIPLE = 22;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 47;
    public const int TRIGGER_CLEANUP = 31;
    public const int CLASSDEF_BULLET = 7;
    public const int ML_COMMENT = 57;
    public const int PARAM_ANIMATION = 17;
    public const int INSTANCE_IDENTIFIER = 43;
    public const int CONST_ANGLE_DOWN = 39;
    public const int TRIGGER_INIT = 30;
    public const int T__59 = 59;
    public const int ACTION_START = 24;
    public const int THIS = 4;
    public const int RECTANGLE = 53;
    public const int CLASSDEF_PLAYER = 6;
    public const int PARAM_POSITION = 14;
    public const int DIGIT = 51;
    public const int CLASSDEF_EVENT = 11;
    public const int SHAPE_CIRCLE = 45;
    public const int ACTION_PERIODIC = 20;
    public const int PARAM_GAMEAREA = 13;
    public const int PARAM_FPS = 12;
    public const int PREDEF_ANGLE_CURRENT = 38;
    public const int CLASSDEF_ENEMY = 8;
    public const int PARAM_TRAJECTORY = 19;
    public const int ACTION_SUMMON = 26;
    public const int NUMBER = 49;
    public const int WHITESPACE = 56;
    public const int HEX_DIGIT = 46;
    public const int TRIGGER_TIME = 32;
    public const int ACTION_STOP = 25;
    public const int TRIGGER_PERIODIC = 33;
    public const int TRIGGER_ANIMATION_END = 35;
    public const int ACTION_FIRE = 21;
    public const int TRIGGER_EVENT = 36;
    public const int CLASSDEF_STATE = 10;
    public const int CARDINAL_DIRECTION = 48;
    public const int PARAM_COLOR = 15;
    public const int T__71 = 71;
    public const int VARIABLE = 44;
    public const int T__70 = 70;
    public const int PARAM_SPEED = 16;
    public const int CLASS_IDENTIFIER = 54;
    public const int CONST_ANGLE_LEFT = 41;
    public const int ACTION_RAISE = 29;
    public const int SL_COMMENT = 58;
    public const int PREDEF_ANGLE_TOWARD_PLAYER = 37;
    public const int ACTION_DIE = 23;
    public const int CLASSDEF_ENGINE = 5;
    public const int ACTION_PLAY_ANIMATION = 27;
    public const int STRING = 55;

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:267:1: gbs returns [Gbs s] : ( classdef )* ;
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:276:2: ( ( classdef )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:276:4: ( classdef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:276:4: ( classdef )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:276:4: classdef
            			    {
            			    	PushFollow(FOLLOW_classdef_in_gbs1007);
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

    public class shape_return : ParserRuleReturnScope
    {
        public Shapedef s;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "shape"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:279:1: shape returns [Shapedef s] : c= circle_shape ;
    public GbsParser.shape_return shape() // throws RecognitionException [1]
    {   
        GbsParser.shape_return retval = new GbsParser.shape_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.circle_shape_return c = default(GbsParser.circle_shape_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:280:2: (c= circle_shape )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:280:4: c= circle_shape
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_circle_shape_in_shape1027);
            	c = circle_shape();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, c.Tree);
            	 retval.s =  ((c != null) ? c.s : default(Shapedef)); 

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
    // $ANTLR end "shape"

    public class circle_shape_return : ParserRuleReturnScope
    {
        public Shapedef s;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "circle_shape"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:283:1: circle_shape returns [Shapedef s] : SHAPE_CIRCLE '(' center= POINT ',' radius= formula ',' initialAngle= formula ')' ;
    public GbsParser.circle_shape_return circle_shape() // throws RecognitionException [1]
    {   
        GbsParser.circle_shape_return retval = new GbsParser.circle_shape_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken center = null;
        IToken SHAPE_CIRCLE2 = null;
        IToken char_literal3 = null;
        IToken char_literal4 = null;
        IToken char_literal5 = null;
        IToken char_literal6 = null;
        GbsParser.formula_return radius = default(GbsParser.formula_return);

        GbsParser.formula_return initialAngle = default(GbsParser.formula_return);


        object center_tree=null;
        object SHAPE_CIRCLE2_tree=null;
        object char_literal3_tree=null;
        object char_literal4_tree=null;
        object char_literal5_tree=null;
        object char_literal6_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:284:2: ( SHAPE_CIRCLE '(' center= POINT ',' radius= formula ',' initialAngle= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:284:4: SHAPE_CIRCLE '(' center= POINT ',' radius= formula ',' initialAngle= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SHAPE_CIRCLE2=(IToken)Match(input,SHAPE_CIRCLE,FOLLOW_SHAPE_CIRCLE_in_circle_shape1045); 
            		SHAPE_CIRCLE2_tree = (object)adaptor.Create(SHAPE_CIRCLE2);
            		adaptor.AddChild(root_0, SHAPE_CIRCLE2_tree);

            	char_literal3=(IToken)Match(input,59,FOLLOW_59_in_circle_shape1047); 
            		char_literal3_tree = (object)adaptor.Create(char_literal3);
            		adaptor.AddChild(root_0, char_literal3_tree);

            	center=(IToken)Match(input,POINT,FOLLOW_POINT_in_circle_shape1051); 
            		center_tree = (object)adaptor.Create(center);
            		adaptor.AddChild(root_0, center_tree);

            	char_literal4=(IToken)Match(input,60,FOLLOW_60_in_circle_shape1053); 
            		char_literal4_tree = (object)adaptor.Create(char_literal4);
            		adaptor.AddChild(root_0, char_literal4_tree);

            	PushFollow(FOLLOW_formula_in_circle_shape1057);
            	radius = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, radius.Tree);
            	char_literal5=(IToken)Match(input,60,FOLLOW_60_in_circle_shape1059); 
            		char_literal5_tree = (object)adaptor.Create(char_literal5);
            		adaptor.AddChild(root_0, char_literal5_tree);

            	PushFollow(FOLLOW_formula_in_circle_shape1063);
            	initialAngle = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, initialAngle.Tree);
            	char_literal6=(IToken)Match(input,61,FOLLOW_61_in_circle_shape1065); 
            		char_literal6_tree = (object)adaptor.Create(char_literal6);
            		adaptor.AddChild(root_0, char_literal6_tree);

            	 retval.s =  new CircleShapedef(Point2.Parse(center.Text), ((radius != null) ? radius.f : default(Formula)), ((initialAngle != null) ? initialAngle.f : default(Formula))); 

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
    // $ANTLR end "circle_shape"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:287:1: formula returns [Formula f] : a= factor_formula ( ( '+' | '-' ) b= factor_formula )* ;
    public GbsParser.formula_return formula() // throws RecognitionException [1]
    {   
        formula_stack.Push(new formula_scope());
        GbsParser.formula_return retval = new GbsParser.formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal7 = null;
        IToken char_literal8 = null;
        GbsParser.factor_formula_return a = default(GbsParser.factor_formula_return);

        GbsParser.factor_formula_return b = default(GbsParser.factor_formula_return);


        object char_literal7_tree=null;
        object char_literal8_tree=null;

         
        	((formula_scope)formula_stack.Peek()).add =  new List<bool>();
        	((formula_scope)formula_stack.Peek()).terms =  new List<Formula>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:2: (a= factor_formula ( ( '+' | '-' ) b= factor_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:4: a= factor_formula ( ( '+' | '-' ) b= factor_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_factor_formula_in_formula1096);
            	a = factor_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:21: ( ( '+' | '-' ) b= factor_formula )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= 62 && LA3_0 <= 63)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:23: ( '+' | '-' ) b= factor_formula
            			    {
            			    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:23: ( '+' | '-' )
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == 62) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	else if ( (LA2_0 == 63) )
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
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:25: '+'
            			    	        {
            			    	        	char_literal7=(IToken)Match(input,62,FOLLOW_62_in_formula1102); 
            			    	        		char_literal7_tree = (object)adaptor.Create(char_literal7);
            			    	        		adaptor.AddChild(root_0, char_literal7_tree);

            			    	        	 ((formula_scope)formula_stack.Peek()).add.Add(true); 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:298:60: '-'
            			    	        {
            			    	        	char_literal8=(IToken)Match(input,63,FOLLOW_63_in_formula1108); 
            			    	        		char_literal8_tree = (object)adaptor.Create(char_literal8);
            			    	        		adaptor.AddChild(root_0, char_literal8_tree);

            			    	        	 ((formula_scope)formula_stack.Peek()).add.Add(false); 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_factor_formula_in_formula1116);
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
        protected internal List<byte> mul;
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:301:1: factor_formula returns [Formula f] : a= simple_formula ( ( '*' | '/' | '%' ) b= simple_formula )* ;
    public GbsParser.factor_formula_return factor_formula() // throws RecognitionException [1]
    {   
        factor_formula_stack.Push(new factor_formula_scope());
        GbsParser.factor_formula_return retval = new GbsParser.factor_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal9 = null;
        IToken char_literal10 = null;
        IToken char_literal11 = null;
        GbsParser.simple_formula_return a = default(GbsParser.simple_formula_return);

        GbsParser.simple_formula_return b = default(GbsParser.simple_formula_return);


        object char_literal9_tree=null;
        object char_literal10_tree=null;
        object char_literal11_tree=null;

         
        	((factor_formula_scope)factor_formula_stack.Peek()).mul =  new List<byte>();
        	((factor_formula_scope)factor_formula_stack.Peek()).factors =  new List<Formula>();

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:2: (a= simple_formula ( ( '*' | '/' | '%' ) b= simple_formula )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:4: a= simple_formula ( ( '*' | '/' | '%' ) b= simple_formula )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_simple_formula_in_factor_formula1153);
            	a = simple_formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:21: ( ( '*' | '/' | '%' ) b= simple_formula )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= 64 && LA5_0 <= 66)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:23: ( '*' | '/' | '%' ) b= simple_formula
            			    {
            			    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:23: ( '*' | '/' | '%' )
            			    	int alt4 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 64:
            			    		{
            			    	    alt4 = 1;
            			    	    }
            			    	    break;
            			    	case 65:
            			    		{
            			    	    alt4 = 2;
            			    	    }
            			    	    break;
            			    	case 66:
            			    		{
            			    	    alt4 = 3;
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
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:25: '*'
            			    	        {
            			    	        	char_literal9=(IToken)Match(input,64,FOLLOW_64_in_factor_formula1159); 
            			    	        		char_literal9_tree = (object)adaptor.Create(char_literal9);
            			    	        		adaptor.AddChild(root_0, char_literal9_tree);

            			    	        	 ((factor_formula_scope)factor_formula_stack.Peek()).mul.Add(0); 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:64: '/'
            			    	        {
            			    	        	char_literal10=(IToken)Match(input,65,FOLLOW_65_in_factor_formula1165); 
            			    	        		char_literal10_tree = (object)adaptor.Create(char_literal10);
            			    	        		adaptor.AddChild(root_0, char_literal10_tree);

            			    	        	 ((factor_formula_scope)factor_formula_stack.Peek()).mul.Add(1); 

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:312:103: '%'
            			    	        {
            			    	        	char_literal11=(IToken)Match(input,66,FOLLOW_66_in_factor_formula1171); 
            			    	        		char_literal11_tree = (object)adaptor.Create(char_literal11);
            			    	        		adaptor.AddChild(root_0, char_literal11_tree);

            			    	        	 ((factor_formula_scope)factor_formula_stack.Peek()).mul.Add(2); 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_simple_formula_in_factor_formula1179);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:315:1: simple_formula returns [Formula f] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | v= VARIABLE | '(' sf= formula ')' );
    public GbsParser.simple_formula_return simple_formula() // throws RecognitionException [1]
    {   
        GbsParser.simple_formula_return retval = new GbsParser.simple_formula_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken c = null;
        IToken v = null;
        IToken char_literal12 = null;
        IToken CONST_ANGLE_DOWN13 = null;
        IToken CONST_ANGLE_UP14 = null;
        IToken CONST_ANGLE_LEFT15 = null;
        IToken CONST_ANGLE_RIGHT16 = null;
        IToken PREDEF_ANGLE_TOWARD_PLAYER17 = null;
        IToken PREDEF_ANGLE_CURRENT18 = null;
        IToken char_literal19 = null;
        IToken char_literal20 = null;
        GbsParser.formula_return sf = default(GbsParser.formula_return);


        object c_tree=null;
        object v_tree=null;
        object char_literal12_tree=null;
        object CONST_ANGLE_DOWN13_tree=null;
        object CONST_ANGLE_UP14_tree=null;
        object CONST_ANGLE_LEFT15_tree=null;
        object CONST_ANGLE_RIGHT16_tree=null;
        object PREDEF_ANGLE_TOWARD_PLAYER17_tree=null;
        object PREDEF_ANGLE_CURRENT18_tree=null;
        object char_literal19_tree=null;
        object char_literal20_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:2: (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | v= VARIABLE | '(' sf= formula ')' )
            int alt6 = 10;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:316:4: c= NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1203); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	 retval.f =  new ConstValueFormula(float.Parse(c.Text)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:317:4: c= NUMBER '°'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	c=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_simple_formula1212); 
                    		c_tree = (object)adaptor.Create(c);
                    		adaptor.AddChild(root_0, c_tree);

                    	char_literal12=(IToken)Match(input,67,FOLLOW_67_in_simple_formula1214); 
                    		char_literal12_tree = (object)adaptor.Create(char_literal12);
                    		adaptor.AddChild(root_0, char_literal12_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.DegreeToRadian(float.Parse(c.Text))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:318:4: CONST_ANGLE_DOWN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_DOWN13=(IToken)Match(input,CONST_ANGLE_DOWN,FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1221); 
                    		CONST_ANGLE_DOWN13_tree = (object)adaptor.Create(CONST_ANGLE_DOWN13);
                    		adaptor.AddChild(root_0, CONST_ANGLE_DOWN13_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_DOWN); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:319:4: CONST_ANGLE_UP
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_UP14=(IToken)Match(input,CONST_ANGLE_UP,FOLLOW_CONST_ANGLE_UP_in_simple_formula1228); 
                    		CONST_ANGLE_UP14_tree = (object)adaptor.Create(CONST_ANGLE_UP14);
                    		adaptor.AddChild(root_0, CONST_ANGLE_UP14_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_UP); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:320:4: CONST_ANGLE_LEFT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_LEFT15=(IToken)Match(input,CONST_ANGLE_LEFT,FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1235); 
                    		CONST_ANGLE_LEFT15_tree = (object)adaptor.Create(CONST_ANGLE_LEFT15);
                    		adaptor.AddChild(root_0, CONST_ANGLE_LEFT15_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_LEFT); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:321:4: CONST_ANGLE_RIGHT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CONST_ANGLE_RIGHT16=(IToken)Match(input,CONST_ANGLE_RIGHT,FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1242); 
                    		CONST_ANGLE_RIGHT16_tree = (object)adaptor.Create(CONST_ANGLE_RIGHT16);
                    		adaptor.AddChild(root_0, CONST_ANGLE_RIGHT16_tree);

                    	 retval.f =  new ConstValueFormula(MathHelper.ANGLE_RIGHT); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:322:4: PREDEF_ANGLE_TOWARD_PLAYER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_TOWARD_PLAYER17=(IToken)Match(input,PREDEF_ANGLE_TOWARD_PLAYER,FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1249); 
                    		PREDEF_ANGLE_TOWARD_PLAYER17_tree = (object)adaptor.Create(PREDEF_ANGLE_TOWARD_PLAYER17);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_TOWARD_PLAYER17_tree);

                    	 retval.f =  new AngleTowardPlayerFormula(); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:323:4: PREDEF_ANGLE_CURRENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PREDEF_ANGLE_CURRENT18=(IToken)Match(input,PREDEF_ANGLE_CURRENT,FOLLOW_PREDEF_ANGLE_CURRENT_in_simple_formula1256); 
                    		PREDEF_ANGLE_CURRENT18_tree = (object)adaptor.Create(PREDEF_ANGLE_CURRENT18);
                    		adaptor.AddChild(root_0, PREDEF_ANGLE_CURRENT18_tree);

                    	 retval.f =  new CurrentAngleFormula(); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:324:4: v= VARIABLE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	v=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_simple_formula1265); 
                    		v_tree = (object)adaptor.Create(v);
                    		adaptor.AddChild(root_0, v_tree);

                    	 retval.f =  new VariableFormula(v.Text); 

                    }
                    break;
                case 10 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:325:4: '(' sf= formula ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal19=(IToken)Match(input,59,FOLLOW_59_in_simple_formula1272); 
                    		char_literal19_tree = (object)adaptor.Create(char_literal19);
                    		adaptor.AddChild(root_0, char_literal19_tree);

                    	PushFollow(FOLLOW_formula_in_simple_formula1276);
                    	sf = formula();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sf.Tree);
                    	char_literal20=(IToken)Match(input,61,FOLLOW_61_in_simple_formula1278); 
                    		char_literal20_tree = (object)adaptor.Create(char_literal20);
                    		adaptor.AddChild(root_0, char_literal20_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:328:1: range returns [Range range] : a= NUMBER '..' b= NUMBER ;
    public GbsParser.range_return range() // throws RecognitionException [1]
    {   
        GbsParser.range_return retval = new GbsParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken string_literal21 = null;

        object a_tree=null;
        object b_tree=null;
        object string_literal21_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:329:2: (a= NUMBER '..' b= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:329:4: a= NUMBER '..' b= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	a=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_range1298); 
            		a_tree = (object)adaptor.Create(a);
            		adaptor.AddChild(root_0, a_tree);

            	string_literal21=(IToken)Match(input,68,FOLLOW_68_in_range1300); 
            		string_literal21_tree = (object)adaptor.Create(string_literal21);
            		adaptor.AddChild(root_0, string_literal21_tree);

            	b=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_range1304); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:332:1: param returns [Param p] : (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param | tp= trajectory_param | csp= custom_param );
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

        GbsParser.trajectory_param_return tp = default(GbsParser.trajectory_param_return);

        GbsParser.custom_param_return csp = default(GbsParser.custom_param_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:333:2: (fp= fps_param | gap= gamearea_param | pp= position_param | sp= speed_param | ap= animation_param | cp= color_param | scp= scrolling_param | tp= trajectory_param | csp= custom_param )
            int alt7 = 9;
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
            case PARAM_TRAJECTORY:
            	{
                alt7 = 8;
                }
                break;
            case VARIABLE:
            	{
                alt7 = 9;
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:333:4: fp= fps_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fps_param_in_param1324);
                    	fp = fps_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fp.Tree);
                    	 retval.p =  ((fp != null) ? fp.p : default(Param)); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:334:4: gap= gamearea_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_gamearea_param_in_param1340);
                    	gap = gamearea_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, gap.Tree);
                    	 retval.p =  ((gap != null) ? gap.p : default(Param)); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:335:4: pp= position_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_position_param_in_param1350);
                    	pp = position_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pp.Tree);
                    	 retval.p =  ((pp != null) ? pp.p : default(Param)); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:336:4: sp= speed_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_speed_param_in_param1361);
                    	sp = speed_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sp.Tree);
                    	 retval.p =  ((sp != null) ? sp.p : default(Param)); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:337:4: ap= animation_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_animation_param_in_param1375);
                    	ap = animation_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ap.Tree);
                    	 retval.p =  ((ap != null) ? ap.p : default(Param)); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:338:4: cp= color_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_color_param_in_param1385);
                    	cp = color_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, cp.Tree);
                    	 retval.p =  ((cp != null) ? cp.p : default(Param)); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:339:4: scp= scrolling_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scrolling_param_in_param1399);
                    	scp = scrolling_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, scp.Tree);
                    	 retval.p =  ((scp != null) ? scp.p : default(Param)); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:340:4: tp= trajectory_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trajectory_param_in_param1408);
                    	tp = trajectory_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tp.Tree);
                    	 retval.p =  ((tp != null) ? tp.p : default(Param)); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:341:4: csp= custom_param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_custom_param_in_param1417);
                    	csp = custom_param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, csp.Tree);
                    	 retval.p =  ((csp != null) ? csp.p : default(Param)); 

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:344:1: fps_param returns [Param p] : PARAM_FPS '=' fps= NUMBER ;
    public GbsParser.fps_param_return fps_param() // throws RecognitionException [1]
    {   
        GbsParser.fps_param_return retval = new GbsParser.fps_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken fps = null;
        IToken PARAM_FPS22 = null;
        IToken char_literal23 = null;

        object fps_tree=null;
        object PARAM_FPS22_tree=null;
        object char_literal23_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:2: ( PARAM_FPS '=' fps= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:345:4: PARAM_FPS '=' fps= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_FPS22=(IToken)Match(input,PARAM_FPS,FOLLOW_PARAM_FPS_in_fps_param1437); 
            		PARAM_FPS22_tree = (object)adaptor.Create(PARAM_FPS22);
            		adaptor.AddChild(root_0, PARAM_FPS22_tree);

            	char_literal23=(IToken)Match(input,69,FOLLOW_69_in_fps_param1439); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	fps=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_fps_param1443); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:348:1: gamearea_param returns [Param p] : PARAM_GAMEAREA '=' area= RECTANGLE ;
    public GbsParser.gamearea_param_return gamearea_param() // throws RecognitionException [1]
    {   
        GbsParser.gamearea_param_return retval = new GbsParser.gamearea_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken area = null;
        IToken PARAM_GAMEAREA24 = null;
        IToken char_literal25 = null;

        object area_tree=null;
        object PARAM_GAMEAREA24_tree=null;
        object char_literal25_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:349:2: ( PARAM_GAMEAREA '=' area= RECTANGLE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:349:4: PARAM_GAMEAREA '=' area= RECTANGLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_GAMEAREA24=(IToken)Match(input,PARAM_GAMEAREA,FOLLOW_PARAM_GAMEAREA_in_gamearea_param1460); 
            		PARAM_GAMEAREA24_tree = (object)adaptor.Create(PARAM_GAMEAREA24);
            		adaptor.AddChild(root_0, PARAM_GAMEAREA24_tree);

            	char_literal25=(IToken)Match(input,69,FOLLOW_69_in_gamearea_param1462); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	area=(IToken)Match(input,RECTANGLE,FOLLOW_RECTANGLE_in_gamearea_param1466); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:352:1: position_param returns [Param p] : PARAM_POSITION '=' pos= POINT ;
    public GbsParser.position_param_return position_param() // throws RecognitionException [1]
    {   
        GbsParser.position_param_return retval = new GbsParser.position_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken pos = null;
        IToken PARAM_POSITION26 = null;
        IToken char_literal27 = null;

        object pos_tree=null;
        object PARAM_POSITION26_tree=null;
        object char_literal27_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:353:2: ( PARAM_POSITION '=' pos= POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:353:4: PARAM_POSITION '=' pos= POINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_POSITION26=(IToken)Match(input,PARAM_POSITION,FOLLOW_PARAM_POSITION_in_position_param1484); 
            		PARAM_POSITION26_tree = (object)adaptor.Create(PARAM_POSITION26);
            		adaptor.AddChild(root_0, PARAM_POSITION26_tree);

            	char_literal27=(IToken)Match(input,69,FOLLOW_69_in_position_param1486); 
            		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);

            	pos=(IToken)Match(input,POINT,FOLLOW_POINT_in_position_param1490); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:356:1: speed_param returns [Param p] : PARAM_SPEED '=' speed= NUMBER ;
    public GbsParser.speed_param_return speed_param() // throws RecognitionException [1]
    {   
        GbsParser.speed_param_return retval = new GbsParser.speed_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken speed = null;
        IToken PARAM_SPEED28 = null;
        IToken char_literal29 = null;

        object speed_tree=null;
        object PARAM_SPEED28_tree=null;
        object char_literal29_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:357:2: ( PARAM_SPEED '=' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:357:4: PARAM_SPEED '=' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SPEED28=(IToken)Match(input,PARAM_SPEED,FOLLOW_PARAM_SPEED_in_speed_param1508); 
            		PARAM_SPEED28_tree = (object)adaptor.Create(PARAM_SPEED28);
            		adaptor.AddChild(root_0, PARAM_SPEED28_tree);

            	char_literal29=(IToken)Match(input,69,FOLLOW_69_in_speed_param1510); 
            		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		adaptor.AddChild(root_0, char_literal29_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_speed_param1514); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:360:1: animation_param returns [Param p] : PARAM_ANIMATION '=' anim= STRING ;
    public GbsParser.animation_param_return animation_param() // throws RecognitionException [1]
    {   
        GbsParser.animation_param_return retval = new GbsParser.animation_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken PARAM_ANIMATION30 = null;
        IToken char_literal31 = null;

        object anim_tree=null;
        object PARAM_ANIMATION30_tree=null;
        object char_literal31_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:361:2: ( PARAM_ANIMATION '=' anim= STRING )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:361:4: PARAM_ANIMATION '=' anim= STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_ANIMATION30=(IToken)Match(input,PARAM_ANIMATION,FOLLOW_PARAM_ANIMATION_in_animation_param1532); 
            		PARAM_ANIMATION30_tree = (object)adaptor.Create(PARAM_ANIMATION30);
            		adaptor.AddChild(root_0, PARAM_ANIMATION30_tree);

            	char_literal31=(IToken)Match(input,69,FOLLOW_69_in_animation_param1534); 
            		char_literal31_tree = (object)adaptor.Create(char_literal31);
            		adaptor.AddChild(root_0, char_literal31_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_animation_param1538); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:364:1: color_param returns [Param p] : PARAM_COLOR '=' color= COLOR ;
    public GbsParser.color_param_return color_param() // throws RecognitionException [1]
    {   
        GbsParser.color_param_return retval = new GbsParser.color_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken color = null;
        IToken PARAM_COLOR32 = null;
        IToken char_literal33 = null;

        object color_tree=null;
        object PARAM_COLOR32_tree=null;
        object char_literal33_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:365:2: ( PARAM_COLOR '=' color= COLOR )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:365:4: PARAM_COLOR '=' color= COLOR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_COLOR32=(IToken)Match(input,PARAM_COLOR,FOLLOW_PARAM_COLOR_in_color_param1556); 
            		PARAM_COLOR32_tree = (object)adaptor.Create(PARAM_COLOR32);
            		adaptor.AddChild(root_0, PARAM_COLOR32_tree);

            	char_literal33=(IToken)Match(input,69,FOLLOW_69_in_color_param1558); 
            		char_literal33_tree = (object)adaptor.Create(char_literal33);
            		adaptor.AddChild(root_0, char_literal33_tree);

            	color=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_color_param1562); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:368:1: scrolling_param returns [Param p] : PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER ;
    public GbsParser.scrolling_param_return scrolling_param() // throws RecognitionException [1]
    {   
        GbsParser.scrolling_param_return retval = new GbsParser.scrolling_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken dir = null;
        IToken speed = null;
        IToken PARAM_SCROLLING34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;

        object dir_tree=null;
        object speed_tree=null;
        object PARAM_SCROLLING34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:2: ( PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:369:4: PARAM_SCROLLING '=' dir= DIRECTION ',' speed= NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_SCROLLING34=(IToken)Match(input,PARAM_SCROLLING,FOLLOW_PARAM_SCROLLING_in_scrolling_param1580); 
            		PARAM_SCROLLING34_tree = (object)adaptor.Create(PARAM_SCROLLING34);
            		adaptor.AddChild(root_0, PARAM_SCROLLING34_tree);

            	char_literal35=(IToken)Match(input,69,FOLLOW_69_in_scrolling_param1582); 
            		char_literal35_tree = (object)adaptor.Create(char_literal35);
            		adaptor.AddChild(root_0, char_literal35_tree);

            	dir=(IToken)Match(input,DIRECTION,FOLLOW_DIRECTION_in_scrolling_param1586); 
            		dir_tree = (object)adaptor.Create(dir);
            		adaptor.AddChild(root_0, dir_tree);

            	char_literal36=(IToken)Match(input,60,FOLLOW_60_in_scrolling_param1588); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

            	speed=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_scrolling_param1592); 
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

    public class trajectory_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "trajectory_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:372:1: trajectory_param returns [Param p] : PARAM_TRAJECTORY '=' traj= shape ;
    public GbsParser.trajectory_param_return trajectory_param() // throws RecognitionException [1]
    {   
        GbsParser.trajectory_param_return retval = new GbsParser.trajectory_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PARAM_TRAJECTORY37 = null;
        IToken char_literal38 = null;
        GbsParser.shape_return traj = default(GbsParser.shape_return);


        object PARAM_TRAJECTORY37_tree=null;
        object char_literal38_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:373:2: ( PARAM_TRAJECTORY '=' traj= shape )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:373:4: PARAM_TRAJECTORY '=' traj= shape
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAM_TRAJECTORY37=(IToken)Match(input,PARAM_TRAJECTORY,FOLLOW_PARAM_TRAJECTORY_in_trajectory_param1609); 
            		PARAM_TRAJECTORY37_tree = (object)adaptor.Create(PARAM_TRAJECTORY37);
            		adaptor.AddChild(root_0, PARAM_TRAJECTORY37_tree);

            	char_literal38=(IToken)Match(input,69,FOLLOW_69_in_trajectory_param1611); 
            		char_literal38_tree = (object)adaptor.Create(char_literal38);
            		adaptor.AddChild(root_0, char_literal38_tree);

            	PushFollow(FOLLOW_shape_in_trajectory_param1615);
            	traj = shape();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, traj.Tree);
            	 retval.p =  new TrajectoryParam(((traj != null) ? traj.s : default(Shapedef))); 

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
    // $ANTLR end "trajectory_param"

    public class custom_param_return : ParserRuleReturnScope
    {
        public Param p;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "custom_param"
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:376:1: custom_param returns [Param p] : v= VARIABLE '=' f= formula ;
    public GbsParser.custom_param_return custom_param() // throws RecognitionException [1]
    {   
        GbsParser.custom_param_return retval = new GbsParser.custom_param_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken v = null;
        IToken char_literal39 = null;
        GbsParser.formula_return f = default(GbsParser.formula_return);


        object v_tree=null;
        object char_literal39_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:2: (v= VARIABLE '=' f= formula )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:377:4: v= VARIABLE '=' f= formula
            {
            	root_0 = (object)adaptor.GetNilNode();

            	v=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_custom_param1634); 
            		v_tree = (object)adaptor.Create(v);
            		adaptor.AddChild(root_0, v_tree);

            	char_literal39=(IToken)Match(input,69,FOLLOW_69_in_custom_param1636); 
            		char_literal39_tree = (object)adaptor.Create(char_literal39);
            		adaptor.AddChild(root_0, char_literal39_tree);

            	PushFollow(FOLLOW_formula_in_custom_param1640);
            	f = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, f.Tree);
            	 retval.p =  CustomParam.Create(v.Text, ((f != null) ? f.f : default(Formula))); 

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
    // $ANTLR end "custom_param"

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:380:1: classdef returns [Classdef en] : (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:391:2: (ee= engine_classdef | pe= player_classdef | be= bullet_classdef | ene= enemy_classdef | eve= event_classdef | ste= state_classdef | se= script_classdef )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:391:4: ee= engine_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_engine_classdef_in_classdef1671);
                    	ee = engine_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ee.Tree);
                    	 retval.en =  ((ee != null) ? ee.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:392:4: pe= player_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_player_classdef_in_classdef1680);
                    	pe = player_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pe.Tree);
                    	 retval.en =  ((pe != null) ? pe.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:393:4: be= bullet_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bullet_classdef_in_classdef1689);
                    	be = bullet_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, be.Tree);
                    	 retval.en =  ((be != null) ? be.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:394:4: ene= enemy_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enemy_classdef_in_classdef1698);
                    	ene = enemy_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ene.Tree);
                    	 retval.en =  ((ene != null) ? ene.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:395:4: eve= event_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_event_classdef_in_classdef1707);
                    	eve = event_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, eve.Tree);
                    	 retval.en =  ((eve != null) ? eve.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:396:4: ste= state_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_state_classdef_in_classdef1716);
                    	ste = state_classdef();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ste.Tree);
                    	 retval.en =  ((ste != null) ? ste.en : default(Classdef)); ((gbs_scope)gbs_stack.Peek()).classdefs.Add(retval.en); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:397:4: se= script_classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_script_classdef_in_classdef1725);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:400:1: classdef_content : (t= trigger | se= classdef );
    public GbsParser.classdef_content_return classdef_content() // throws RecognitionException [1]
    {   
        GbsParser.classdef_content_return retval = new GbsParser.classdef_content_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.trigger_return t = default(GbsParser.trigger_return);

        GbsParser.classdef_return se = default(GbsParser.classdef_return);



        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:401:2: (t= trigger | se= classdef )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:401:4: t= trigger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_trigger_in_classdef_content1740);
                    	t = trigger();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, t.Tree);
                    	 ((classdef_scope)classdef_stack.Peek()).triggers.Add(((t != null) ? t.t : default(Trigger))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:402:4: se= classdef
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classdef_in_classdef_content1756);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:405:1: engine_classdef returns [Classdef en] : CLASSDEF_ENGINE '{' ( classdef_content )* '}' ;
    public GbsParser.engine_classdef_return engine_classdef() // throws RecognitionException [1]
    {   
        GbsParser.engine_classdef_return retval = new GbsParser.engine_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASSDEF_ENGINE40 = null;
        IToken char_literal41 = null;
        IToken char_literal43 = null;
        GbsParser.classdef_content_return classdef_content42 = default(GbsParser.classdef_content_return);


        object CLASSDEF_ENGINE40_tree=null;
        object char_literal41_tree=null;
        object char_literal43_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:406:2: ( CLASSDEF_ENGINE '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:406:4: CLASSDEF_ENGINE '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENGINE40=(IToken)Match(input,CLASSDEF_ENGINE,FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1781); 
            		CLASSDEF_ENGINE40_tree = (object)adaptor.Create(CLASSDEF_ENGINE40);
            		adaptor.AddChild(root_0, CLASSDEF_ENGINE40_tree);

            	char_literal41=(IToken)Match(input,70,FOLLOW_70_in_engine_classdef1783); 
            		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		adaptor.AddChild(root_0, char_literal41_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:406:24: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:406:24: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_engine_classdef1785);
            			    	classdef_content42 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content42.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal43=(IToken)Match(input,71,FOLLOW_71_in_engine_classdef1788); 
            		char_literal43_tree = (object)adaptor.Create(char_literal43);
            		adaptor.AddChild(root_0, char_literal43_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:409:1: player_classdef returns [Classdef en] : CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.player_classdef_return player_classdef() // throws RecognitionException [1]
    {   
        GbsParser.player_classdef_return retval = new GbsParser.player_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_PLAYER44 = null;
        IToken char_literal45 = null;
        IToken char_literal47 = null;
        GbsParser.classdef_content_return classdef_content46 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_PLAYER44_tree=null;
        object char_literal45_tree=null;
        object char_literal47_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:2: ( CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:4: CLASSDEF_PLAYER name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_PLAYER44=(IToken)Match(input,CLASSDEF_PLAYER,FOLLOW_CLASSDEF_PLAYER_in_player_classdef1806); 
            		CLASSDEF_PLAYER44_tree = (object)adaptor.Create(CLASSDEF_PLAYER44);
            		adaptor.AddChild(root_0, CLASSDEF_PLAYER44_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_player_classdef1810); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal45=(IToken)Match(input,70,FOLLOW_70_in_player_classdef1812); 
            		char_literal45_tree = (object)adaptor.Create(char_literal45);
            		adaptor.AddChild(root_0, char_literal45_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:410:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_player_classdef1814);
            			    	classdef_content46 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content46.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal47=(IToken)Match(input,71,FOLLOW_71_in_player_classdef1817); 
            		char_literal47_tree = (object)adaptor.Create(char_literal47);
            		adaptor.AddChild(root_0, char_literal47_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:413:1: enemy_classdef returns [Classdef en] : CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.enemy_classdef_return enemy_classdef() // throws RecognitionException [1]
    {   
        GbsParser.enemy_classdef_return retval = new GbsParser.enemy_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_ENEMY48 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        GbsParser.classdef_content_return classdef_content50 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_ENEMY48_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:2: ( CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:4: CLASSDEF_ENEMY name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_ENEMY48=(IToken)Match(input,CLASSDEF_ENEMY,FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1834); 
            		CLASSDEF_ENEMY48_tree = (object)adaptor.Create(CLASSDEF_ENEMY48);
            		adaptor.AddChild(root_0, CLASSDEF_ENEMY48_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1838); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal49=(IToken)Match(input,70,FOLLOW_70_in_enemy_classdef1840); 
            		char_literal49_tree = (object)adaptor.Create(char_literal49);
            		adaptor.AddChild(root_0, char_literal49_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:414:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_enemy_classdef1842);
            			    	classdef_content50 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content50.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal51=(IToken)Match(input,71,FOLLOW_71_in_enemy_classdef1845); 
            		char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:417:1: bullet_classdef returns [Classdef en] : CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.bullet_classdef_return bullet_classdef() // throws RecognitionException [1]
    {   
        GbsParser.bullet_classdef_return retval = new GbsParser.bullet_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_BULLET52 = null;
        IToken char_literal53 = null;
        IToken char_literal55 = null;
        GbsParser.classdef_content_return classdef_content54 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_BULLET52_tree=null;
        object char_literal53_tree=null;
        object char_literal55_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:418:2: ( CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:418:4: CLASSDEF_BULLET name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_BULLET52=(IToken)Match(input,CLASSDEF_BULLET,FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1862); 
            		CLASSDEF_BULLET52_tree = (object)adaptor.Create(CLASSDEF_BULLET52);
            		adaptor.AddChild(root_0, CLASSDEF_BULLET52_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1866); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal53=(IToken)Match(input,70,FOLLOW_70_in_bullet_classdef1868); 
            		char_literal53_tree = (object)adaptor.Create(char_literal53);
            		adaptor.AddChild(root_0, char_literal53_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:418:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:418:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_bullet_classdef1870);
            			    	classdef_content54 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content54.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	char_literal55=(IToken)Match(input,71,FOLLOW_71_in_bullet_classdef1873); 
            		char_literal55_tree = (object)adaptor.Create(char_literal55);
            		adaptor.AddChild(root_0, char_literal55_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:421:1: script_classdef returns [Classdef en] : CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.script_classdef_return script_classdef() // throws RecognitionException [1]
    {   
        GbsParser.script_classdef_return retval = new GbsParser.script_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_SCRIPT56 = null;
        IToken char_literal57 = null;
        IToken char_literal59 = null;
        GbsParser.classdef_content_return classdef_content58 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_SCRIPT56_tree=null;
        object char_literal57_tree=null;
        object char_literal59_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:422:2: ( CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:422:4: CLASSDEF_SCRIPT name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_SCRIPT56=(IToken)Match(input,CLASSDEF_SCRIPT,FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1891); 
            		CLASSDEF_SCRIPT56_tree = (object)adaptor.Create(CLASSDEF_SCRIPT56);
            		adaptor.AddChild(root_0, CLASSDEF_SCRIPT56_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_script_classdef1895); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal57=(IToken)Match(input,70,FOLLOW_70_in_script_classdef1897); 
            		char_literal57_tree = (object)adaptor.Create(char_literal57);
            		adaptor.AddChild(root_0, char_literal57_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:422:46: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:422:46: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_script_classdef1899);
            			    	classdef_content58 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content58.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	char_literal59=(IToken)Match(input,71,FOLLOW_71_in_script_classdef1902); 
            		char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:425:1: state_classdef returns [Classdef en] : CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' ;
    public GbsParser.state_classdef_return state_classdef() // throws RecognitionException [1]
    {   
        GbsParser.state_classdef_return retval = new GbsParser.state_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_STATE60 = null;
        IToken char_literal61 = null;
        IToken char_literal63 = null;
        GbsParser.classdef_content_return classdef_content62 = default(GbsParser.classdef_content_return);


        object name_tree=null;
        object CLASSDEF_STATE60_tree=null;
        object char_literal61_tree=null;
        object char_literal63_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:2: ( CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:4: CLASSDEF_STATE name= CLASS_IDENTIFIER '{' ( classdef_content )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_STATE60=(IToken)Match(input,CLASSDEF_STATE,FOLLOW_CLASSDEF_STATE_in_state_classdef1919); 
            		CLASSDEF_STATE60_tree = (object)adaptor.Create(CLASSDEF_STATE60);
            		adaptor.AddChild(root_0, CLASSDEF_STATE60_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_state_classdef1923); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	char_literal61=(IToken)Match(input,70,FOLLOW_70_in_state_classdef1925); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:45: ( classdef_content )*
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
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:426:45: classdef_content
            			    {
            			    	PushFollow(FOLLOW_classdef_content_in_state_classdef1927);
            			    	classdef_content62 = classdef_content();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, classdef_content62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	char_literal63=(IToken)Match(input,71,FOLLOW_71_in_state_classdef1930); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:429:1: event_classdef returns [Classdef en] : CLASSDEF_EVENT name= CLASS_IDENTIFIER ;
    public GbsParser.event_classdef_return event_classdef() // throws RecognitionException [1]
    {   
        GbsParser.event_classdef_return retval = new GbsParser.event_classdef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken name = null;
        IToken CLASSDEF_EVENT64 = null;

        object name_tree=null;
        object CLASSDEF_EVENT64_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:430:2: ( CLASSDEF_EVENT name= CLASS_IDENTIFIER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:430:4: CLASSDEF_EVENT name= CLASS_IDENTIFIER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CLASSDEF_EVENT64=(IToken)Match(input,CLASSDEF_EVENT,FOLLOW_CLASSDEF_EVENT_in_event_classdef1949); 
            		CLASSDEF_EVENT64_tree = (object)adaptor.Create(CLASSDEF_EVENT64);
            		adaptor.AddChild(root_0, CLASSDEF_EVENT64_tree);

            	name=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_event_classdef1953); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:433:1: action_list returns [List<Action> actions] : ( action )* ;
    public GbsParser.action_list_return action_list() // throws RecognitionException [1]
    {   
        action_list_stack.Push(new action_list_scope());
        GbsParser.action_list_return retval = new GbsParser.action_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        GbsParser.action_return action65 = default(GbsParser.action_return);



         
        	((action_list_scope)action_list_stack.Peek()).list =  new List<Action>(); 

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:2: ( ( action )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:4: ( action )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:4: ( action )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == THIS || (LA16_0 >= PARAM_FPS && LA16_0 <= ACTION_RAISE) || (LA16_0 >= INSTANCE_IDENTIFIER && LA16_0 <= VARIABLE)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:442:4: action
            			    {
            			    	PushFollow(FOLLOW_action_in_action_list1982);
            			    	action65 = action();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, action65.Tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:445:1: action_target returns [String target] : ( ( THIS )? | ident= INSTANCE_IDENTIFIER );
    public GbsParser.action_target_return action_target() // throws RecognitionException [1]
    {   
        GbsParser.action_target_return retval = new GbsParser.action_target_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ident = null;
        IToken THIS66 = null;

        object ident_tree=null;
        object THIS66_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:2: ( ( THIS )? | ident= INSTANCE_IDENTIFIER )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:4: ( THIS )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:4: ( THIS )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == THIS) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:446:4: THIS
                    	        {
                    	        	THIS66=(IToken)Match(input,THIS,FOLLOW_THIS_in_action_target2000); 
                    	        		THIS66_tree = (object)adaptor.Create(THIS66);
                    	        		adaptor.AddChild(root_0, THIS66_tree);


                    	        }
                    	        break;

                    	}

                    	 retval.target =  "this"; 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:447:4: ident= INSTANCE_IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ident=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_action_target2030); 
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:450:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );
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
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:451:2: (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action )
            int alt19 = 10;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:451:4: pla= play_animation_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_play_animation_action_in_action2045);
                    	pla = play_animation_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pla.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pla != null) ? pla.action : default(Action))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:452:4: pa= periodic_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_periodic_action_in_action2054);
                    	pa = periodic_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, pa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((pa != null) ? pa.action : default(Action))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:453:4: fap= fire_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_action_in_action2070);
                    	fap = fire_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fap.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fap != null) ? fap.action : default(Action))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:454:4: fam= fire_multiple_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fire_multiple_action_in_action2084);
                    	fam = fire_multiple_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fam.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((fam != null) ? fam.action : default(Action))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:455:4: da= die_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_die_action_in_action2094);
                    	da = die_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, da.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((da != null) ? da.action : default(Action))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:456:4: sta= start_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_start_action_in_action2115);
                    	sta = start_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sta.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sta != null) ? sta.action : default(Action))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:457:4: sa= stop_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stop_action_in_action2133);
                    	sa = stop_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sa.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sa != null) ? sa.action : default(Action))); 

                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:458:4: sum= summon_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_summon_action_in_action2153);
                    	sum = summon_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sum.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sum != null) ? sum.action : default(Action))); 

                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:459:4: sea= set_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_action_in_action2170);
                    	sea = set_action();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, sea.Tree);
                    	 ((action_list_scope)action_list_stack.Peek()).list.Add(((sea != null) ? sea.action : default(Action))); 

                    }
                    break;
                case 10 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:460:4: raa= raise_action
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_raise_action_in_action2190);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:463:1: play_animation_action returns [Action action] : target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' ;
    public GbsParser.play_animation_action_return play_animation_action() // throws RecognitionException [1]
    {   
        GbsParser.play_animation_action_return retval = new GbsParser.play_animation_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken anim = null;
        IToken ACTION_PLAY_ANIMATION67 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object anim_tree=null;
        object ACTION_PLAY_ANIMATION67_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:464:2: (target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:464:4: target= action_target ACTION_PLAY_ANIMATION '(' anim= STRING ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_play_animation_action2212);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PLAY_ANIMATION67=(IToken)Match(input,ACTION_PLAY_ANIMATION,FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action2214); 
            		ACTION_PLAY_ANIMATION67_tree = (object)adaptor.Create(ACTION_PLAY_ANIMATION67);
            		adaptor.AddChild(root_0, ACTION_PLAY_ANIMATION67_tree);

            	char_literal68=(IToken)Match(input,59,FOLLOW_59_in_play_animation_action2216); 
            		char_literal68_tree = (object)adaptor.Create(char_literal68);
            		adaptor.AddChild(root_0, char_literal68_tree);

            	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_play_animation_action2220); 
            		anim_tree = (object)adaptor.Create(anim);
            		adaptor.AddChild(root_0, anim_tree);

            	char_literal69=(IToken)Match(input,61,FOLLOW_61_in_play_animation_action2222); 
            		char_literal69_tree = (object)adaptor.Create(char_literal69);
            		adaptor.AddChild(root_0, char_literal69_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:467:1: periodic_action returns [Action action] : target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' ;
    public GbsParser.periodic_action_return periodic_action() // throws RecognitionException [1]
    {   
        GbsParser.periodic_action_return retval = new GbsParser.periodic_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken period = null;
        IToken ACTION_PERIODIC70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return actions = default(GbsParser.action_list_return);


        object period_tree=null;
        object ACTION_PERIODIC70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:468:2: (target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:468:4: target= action_target ACTION_PERIODIC '(' period= NUMBER ')' '{' actions= action_list '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_periodic_action2242);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_PERIODIC70=(IToken)Match(input,ACTION_PERIODIC,FOLLOW_ACTION_PERIODIC_in_periodic_action2244); 
            		ACTION_PERIODIC70_tree = (object)adaptor.Create(ACTION_PERIODIC70);
            		adaptor.AddChild(root_0, ACTION_PERIODIC70_tree);

            	char_literal71=(IToken)Match(input,59,FOLLOW_59_in_periodic_action2246); 
            		char_literal71_tree = (object)adaptor.Create(char_literal71);
            		adaptor.AddChild(root_0, char_literal71_tree);

            	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_periodic_action2250); 
            		period_tree = (object)adaptor.Create(period);
            		adaptor.AddChild(root_0, period_tree);

            	char_literal72=(IToken)Match(input,61,FOLLOW_61_in_periodic_action2252); 
            		char_literal72_tree = (object)adaptor.Create(char_literal72);
            		adaptor.AddChild(root_0, char_literal72_tree);

            	char_literal73=(IToken)Match(input,70,FOLLOW_70_in_periodic_action2254); 
            		char_literal73_tree = (object)adaptor.Create(char_literal73);
            		adaptor.AddChild(root_0, char_literal73_tree);

            	PushFollow(FOLLOW_action_list_in_periodic_action2258);
            	actions = action_list();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, actions.Tree);
            	char_literal74=(IToken)Match(input,71,FOLLOW_71_in_periodic_action2260); 
            		char_literal74_tree = (object)adaptor.Create(char_literal74);
            		adaptor.AddChild(root_0, char_literal74_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:471:1: fire_action returns [Action action] : target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' ;
    public GbsParser.fire_action_return fire_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_action_return retval = new GbsParser.fire_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE75 = null;
        IToken char_literal76 = null;
        IToken char_literal77 = null;
        IToken char_literal78 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return angle = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE75_tree=null;
        object char_literal76_tree=null;
        object char_literal77_tree=null;
        object char_literal78_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:472:2: (target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:472:4: target= action_target ACTION_FIRE '(' bullet= CLASS_IDENTIFIER ',' angle= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_action2280);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE75=(IToken)Match(input,ACTION_FIRE,FOLLOW_ACTION_FIRE_in_fire_action2282); 
            		ACTION_FIRE75_tree = (object)adaptor.Create(ACTION_FIRE75);
            		adaptor.AddChild(root_0, ACTION_FIRE75_tree);

            	char_literal76=(IToken)Match(input,59,FOLLOW_59_in_fire_action2284); 
            		char_literal76_tree = (object)adaptor.Create(char_literal76);
            		adaptor.AddChild(root_0, char_literal76_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_action2288); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal77=(IToken)Match(input,60,FOLLOW_60_in_fire_action2290); 
            		char_literal77_tree = (object)adaptor.Create(char_literal77);
            		adaptor.AddChild(root_0, char_literal77_tree);

            	PushFollow(FOLLOW_formula_in_fire_action2294);
            	angle = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, angle.Tree);
            	char_literal78=(IToken)Match(input,61,FOLLOW_61_in_fire_action2296); 
            		char_literal78_tree = (object)adaptor.Create(char_literal78);
            		adaptor.AddChild(root_0, char_literal78_tree);

            	 retval.action =  FireAction.Create(((target != null) ? target.target : default(String)), bullet.Text, ((angle != null) ? angle.f : default(Formula))); 

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:475:1: fire_multiple_action returns [Action action] : target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')' ;
    public GbsParser.fire_multiple_action_return fire_multiple_action() // throws RecognitionException [1]
    {   
        GbsParser.fire_multiple_action_return retval = new GbsParser.fire_multiple_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken bullet = null;
        IToken ACTION_FIRE_MULTIPLE79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken char_literal82 = null;
        IToken char_literal83 = null;
        IToken char_literal84 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.formula_return baseDir = default(GbsParser.formula_return);

        GbsParser.range_return r = default(GbsParser.range_return);

        GbsParser.formula_return increment = default(GbsParser.formula_return);


        object bullet_tree=null;
        object ACTION_FIRE_MULTIPLE79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object char_literal82_tree=null;
        object char_literal83_tree=null;
        object char_literal84_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:476:2: (target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:476:4: target= action_target ACTION_FIRE_MULTIPLE '(' bullet= CLASS_IDENTIFIER ',' baseDir= formula ',' r= range ',' increment= formula ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_fire_multiple_action2315);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_FIRE_MULTIPLE79=(IToken)Match(input,ACTION_FIRE_MULTIPLE,FOLLOW_ACTION_FIRE_MULTIPLE_in_fire_multiple_action2317); 
            		ACTION_FIRE_MULTIPLE79_tree = (object)adaptor.Create(ACTION_FIRE_MULTIPLE79);
            		adaptor.AddChild(root_0, ACTION_FIRE_MULTIPLE79_tree);

            	char_literal80=(IToken)Match(input,59,FOLLOW_59_in_fire_multiple_action2319); 
            		char_literal80_tree = (object)adaptor.Create(char_literal80);
            		adaptor.AddChild(root_0, char_literal80_tree);

            	bullet=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_fire_multiple_action2323); 
            		bullet_tree = (object)adaptor.Create(bullet);
            		adaptor.AddChild(root_0, bullet_tree);

            	char_literal81=(IToken)Match(input,60,FOLLOW_60_in_fire_multiple_action2325); 
            		char_literal81_tree = (object)adaptor.Create(char_literal81);
            		adaptor.AddChild(root_0, char_literal81_tree);

            	PushFollow(FOLLOW_formula_in_fire_multiple_action2329);
            	baseDir = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, baseDir.Tree);
            	char_literal82=(IToken)Match(input,60,FOLLOW_60_in_fire_multiple_action2331); 
            		char_literal82_tree = (object)adaptor.Create(char_literal82);
            		adaptor.AddChild(root_0, char_literal82_tree);

            	PushFollow(FOLLOW_range_in_fire_multiple_action2335);
            	r = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r.Tree);
            	char_literal83=(IToken)Match(input,60,FOLLOW_60_in_fire_multiple_action2337); 
            		char_literal83_tree = (object)adaptor.Create(char_literal83);
            		adaptor.AddChild(root_0, char_literal83_tree);

            	PushFollow(FOLLOW_formula_in_fire_multiple_action2341);
            	increment = formula();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, increment.Tree);
            	char_literal84=(IToken)Match(input,61,FOLLOW_61_in_fire_multiple_action2343); 
            		char_literal84_tree = (object)adaptor.Create(char_literal84);
            		adaptor.AddChild(root_0, char_literal84_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:479:1: die_action returns [Action action] : target= action_target ACTION_DIE ;
    public GbsParser.die_action_return die_action() // throws RecognitionException [1]
    {   
        GbsParser.die_action_return retval = new GbsParser.die_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_DIE85 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object ACTION_DIE85_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:480:2: (target= action_target ACTION_DIE )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:480:4: target= action_target ACTION_DIE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_die_action2363);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_DIE85=(IToken)Match(input,ACTION_DIE,FOLLOW_ACTION_DIE_in_die_action2365); 
            		ACTION_DIE85_tree = (object)adaptor.Create(ACTION_DIE85);
            		adaptor.AddChild(root_0, ACTION_DIE85_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:483:1: start_action returns [Action action] : target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.start_action_return start_action() // throws RecognitionException [1]
    {   
        GbsParser.start_action_return retval = new GbsParser.start_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_START86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_START86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:484:2: (target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:484:4: target= action_target ACTION_START '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_start_action2385);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_START86=(IToken)Match(input,ACTION_START,FOLLOW_ACTION_START_in_start_action2387); 
            		ACTION_START86_tree = (object)adaptor.Create(ACTION_START86);
            		adaptor.AddChild(root_0, ACTION_START86_tree);

            	char_literal87=(IToken)Match(input,59,FOLLOW_59_in_start_action2389); 
            		char_literal87_tree = (object)adaptor.Create(char_literal87);
            		adaptor.AddChild(root_0, char_literal87_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_start_action2393); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal88=(IToken)Match(input,61,FOLLOW_61_in_start_action2395); 
            		char_literal88_tree = (object)adaptor.Create(char_literal88);
            		adaptor.AddChild(root_0, char_literal88_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:487:1: stop_action returns [Action action] : target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' ;
    public GbsParser.stop_action_return stop_action() // throws RecognitionException [1]
    {   
        GbsParser.stop_action_return retval = new GbsParser.stop_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken st = null;
        IToken ACTION_STOP89 = null;
        IToken char_literal90 = null;
        IToken char_literal91 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object st_tree=null;
        object ACTION_STOP89_tree=null;
        object char_literal90_tree=null;
        object char_literal91_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:488:2: (target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:488:4: target= action_target ACTION_STOP '(' st= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_stop_action2414);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_STOP89=(IToken)Match(input,ACTION_STOP,FOLLOW_ACTION_STOP_in_stop_action2416); 
            		ACTION_STOP89_tree = (object)adaptor.Create(ACTION_STOP89);
            		adaptor.AddChild(root_0, ACTION_STOP89_tree);

            	char_literal90=(IToken)Match(input,59,FOLLOW_59_in_stop_action2418); 
            		char_literal90_tree = (object)adaptor.Create(char_literal90);
            		adaptor.AddChild(root_0, char_literal90_tree);

            	st=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_stop_action2422); 
            		st_tree = (object)adaptor.Create(st);
            		adaptor.AddChild(root_0, st_tree);

            	char_literal91=(IToken)Match(input,61,FOLLOW_61_in_stop_action2424); 
            		char_literal91_tree = (object)adaptor.Create(char_literal91);
            		adaptor.AddChild(root_0, char_literal91_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:491:1: summon_action returns [Action action] : target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? ;
    public GbsParser.summon_action_return summon_action() // throws RecognitionException [1]
    {   
        GbsParser.summon_action_return retval = new GbsParser.summon_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken enemy = null;
        IToken name = null;
        IToken ACTION_SUMMON92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object enemy_tree=null;
        object name_tree=null;
        object ACTION_SUMMON92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:492:2: (target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:492:4: target= action_target ACTION_SUMMON '(' enemy= CLASS_IDENTIFIER ')' name= INSTANCE_IDENTIFIER ( '{' a= action_list '}' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_summon_action2445);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_SUMMON92=(IToken)Match(input,ACTION_SUMMON,FOLLOW_ACTION_SUMMON_in_summon_action2447); 
            		ACTION_SUMMON92_tree = (object)adaptor.Create(ACTION_SUMMON92);
            		adaptor.AddChild(root_0, ACTION_SUMMON92_tree);

            	char_literal93=(IToken)Match(input,59,FOLLOW_59_in_summon_action2449); 
            		char_literal93_tree = (object)adaptor.Create(char_literal93);
            		adaptor.AddChild(root_0, char_literal93_tree);

            	enemy=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_summon_action2453); 
            		enemy_tree = (object)adaptor.Create(enemy);
            		adaptor.AddChild(root_0, enemy_tree);

            	char_literal94=(IToken)Match(input,61,FOLLOW_61_in_summon_action2455); 
            		char_literal94_tree = (object)adaptor.Create(char_literal94);
            		adaptor.AddChild(root_0, char_literal94_tree);

            	name=(IToken)Match(input,INSTANCE_IDENTIFIER,FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2459); 
            		name_tree = (object)adaptor.Create(name);
            		adaptor.AddChild(root_0, name_tree);

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:492:95: ( '{' a= action_list '}' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 70) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:492:97: '{' a= action_list '}'
            	        {
            	        	char_literal95=(IToken)Match(input,70,FOLLOW_70_in_summon_action2463); 
            	        		char_literal95_tree = (object)adaptor.Create(char_literal95);
            	        		adaptor.AddChild(root_0, char_literal95_tree);

            	        	PushFollow(FOLLOW_action_list_in_summon_action2467);
            	        	a = action_list();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, a.Tree);
            	        	char_literal96=(IToken)Match(input,71,FOLLOW_71_in_summon_action2469); 
            	        		char_literal96_tree = (object)adaptor.Create(char_literal96);
            	        		adaptor.AddChild(root_0, char_literal96_tree);


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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:495:1: set_action returns [Action action] : (target= action_target ACTION_SET '(' p= param ')' | p= param );
    public GbsParser.set_action_return set_action() // throws RecognitionException [1]
    {   
        GbsParser.set_action_return retval = new GbsParser.set_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ACTION_SET97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);

        GbsParser.param_return p = default(GbsParser.param_return);


        object ACTION_SET97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:496:2: (target= action_target ACTION_SET '(' p= param ')' | p= param )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( (LA21_0 == THIS || (LA21_0 >= ACTION_PERIODIC && LA21_0 <= ACTION_RAISE) || LA21_0 == INSTANCE_IDENTIFIER) )
            {
                alt21 = 1;
            }
            else if ( ((LA21_0 >= PARAM_FPS && LA21_0 <= PARAM_TRAJECTORY) || LA21_0 == VARIABLE) )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:496:4: target= action_target ACTION_SET '(' p= param ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_action_target_in_set_action2492);
                    	target = action_target();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, target.Tree);
                    	ACTION_SET97=(IToken)Match(input,ACTION_SET,FOLLOW_ACTION_SET_in_set_action2494); 
                    		ACTION_SET97_tree = (object)adaptor.Create(ACTION_SET97);
                    		adaptor.AddChild(root_0, ACTION_SET97_tree);

                    	char_literal98=(IToken)Match(input,59,FOLLOW_59_in_set_action2496); 
                    		char_literal98_tree = (object)adaptor.Create(char_literal98);
                    		adaptor.AddChild(root_0, char_literal98_tree);

                    	PushFollow(FOLLOW_param_in_set_action2500);
                    	p = param();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, p.Tree);
                    	char_literal99=(IToken)Match(input,61,FOLLOW_61_in_set_action2502); 
                    		char_literal99_tree = (object)adaptor.Create(char_literal99);
                    		adaptor.AddChild(root_0, char_literal99_tree);

                    	 retval.action =  new SetAction(((target != null) ? target.target : default(String)), ((p != null) ? p.p : default(Param))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:497:4: p= param
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_param_in_set_action2511);
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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:500:1: raise_action returns [Action action] : target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' ;
    public GbsParser.raise_action_return raise_action() // throws RecognitionException [1]
    {   
        GbsParser.raise_action_return retval = new GbsParser.raise_action_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e = null;
        IToken ACTION_RAISE100 = null;
        IToken char_literal101 = null;
        IToken char_literal102 = null;
        GbsParser.action_target_return target = default(GbsParser.action_target_return);


        object e_tree=null;
        object ACTION_RAISE100_tree=null;
        object char_literal101_tree=null;
        object char_literal102_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:501:2: (target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:501:4: target= action_target ACTION_RAISE '(' e= CLASS_IDENTIFIER ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_action_target_in_raise_action2571);
            	target = action_target();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, target.Tree);
            	ACTION_RAISE100=(IToken)Match(input,ACTION_RAISE,FOLLOW_ACTION_RAISE_in_raise_action2573); 
            		ACTION_RAISE100_tree = (object)adaptor.Create(ACTION_RAISE100);
            		adaptor.AddChild(root_0, ACTION_RAISE100_tree);

            	char_literal101=(IToken)Match(input,59,FOLLOW_59_in_raise_action2575); 
            		char_literal101_tree = (object)adaptor.Create(char_literal101);
            		adaptor.AddChild(root_0, char_literal101_tree);

            	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_raise_action2579); 
            		e_tree = (object)adaptor.Create(e);
            		adaptor.AddChild(root_0, e_tree);

            	char_literal102=(IToken)Match(input,61,FOLLOW_61_in_raise_action2581); 
            		char_literal102_tree = (object)adaptor.Create(char_literal102);
            		adaptor.AddChild(root_0, char_literal102_tree);

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
    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:504:1: trigger returns [Trigger t] : ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' );
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
        IToken TRIGGER_INIT103 = null;
        IToken char_literal104 = null;
        IToken char_literal105 = null;
        IToken TRIGGER_CLEANUP106 = null;
        IToken char_literal107 = null;
        IToken char_literal108 = null;
        IToken TRIGGER_TIME109 = null;
        IToken char_literal110 = null;
        IToken char_literal111 = null;
        IToken char_literal112 = null;
        IToken char_literal113 = null;
        IToken TRIGGER_PERIODIC114 = null;
        IToken char_literal115 = null;
        IToken char_literal116 = null;
        IToken char_literal117 = null;
        IToken char_literal118 = null;
        IToken TRIGGER_SCROLLING119 = null;
        IToken char_literal120 = null;
        IToken char_literal121 = null;
        IToken char_literal122 = null;
        IToken char_literal123 = null;
        IToken TRIGGER_ANIMATION_END124 = null;
        IToken char_literal125 = null;
        IToken char_literal126 = null;
        IToken char_literal127 = null;
        IToken char_literal128 = null;
        IToken TRIGGER_EVENT129 = null;
        IToken char_literal130 = null;
        IToken char_literal131 = null;
        IToken char_literal132 = null;
        IToken char_literal133 = null;
        GbsParser.action_list_return a = default(GbsParser.action_list_return);


        object time_tree=null;
        object period_tree=null;
        object scroll_tree=null;
        object anim_tree=null;
        object e_tree=null;
        object TRIGGER_INIT103_tree=null;
        object char_literal104_tree=null;
        object char_literal105_tree=null;
        object TRIGGER_CLEANUP106_tree=null;
        object char_literal107_tree=null;
        object char_literal108_tree=null;
        object TRIGGER_TIME109_tree=null;
        object char_literal110_tree=null;
        object char_literal111_tree=null;
        object char_literal112_tree=null;
        object char_literal113_tree=null;
        object TRIGGER_PERIODIC114_tree=null;
        object char_literal115_tree=null;
        object char_literal116_tree=null;
        object char_literal117_tree=null;
        object char_literal118_tree=null;
        object TRIGGER_SCROLLING119_tree=null;
        object char_literal120_tree=null;
        object char_literal121_tree=null;
        object char_literal122_tree=null;
        object char_literal123_tree=null;
        object TRIGGER_ANIMATION_END124_tree=null;
        object char_literal125_tree=null;
        object char_literal126_tree=null;
        object char_literal127_tree=null;
        object char_literal128_tree=null;
        object TRIGGER_EVENT129_tree=null;
        object char_literal130_tree=null;
        object char_literal131_tree=null;
        object char_literal132_tree=null;
        object char_literal133_tree=null;

        try 
    	{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:505:2: ( TRIGGER_INIT '{' a= action_list '}' | TRIGGER_CLEANUP '{' a= action_list '}' | TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}' | TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}' | TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}' | TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}' | TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}' )
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:505:4: TRIGGER_INIT '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_INIT103=(IToken)Match(input,TRIGGER_INIT,FOLLOW_TRIGGER_INIT_in_trigger2599); 
                    		TRIGGER_INIT103_tree = (object)adaptor.Create(TRIGGER_INIT103);
                    		adaptor.AddChild(root_0, TRIGGER_INIT103_tree);

                    	char_literal104=(IToken)Match(input,70,FOLLOW_70_in_trigger2601); 
                    		char_literal104_tree = (object)adaptor.Create(char_literal104);
                    		adaptor.AddChild(root_0, char_literal104_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2605);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal105=(IToken)Match(input,71,FOLLOW_71_in_trigger2607); 
                    		char_literal105_tree = (object)adaptor.Create(char_literal105);
                    		adaptor.AddChild(root_0, char_literal105_tree);

                    	 retval.t =  new InitTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:506:4: TRIGGER_CLEANUP '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_CLEANUP106=(IToken)Match(input,TRIGGER_CLEANUP,FOLLOW_TRIGGER_CLEANUP_in_trigger2643); 
                    		TRIGGER_CLEANUP106_tree = (object)adaptor.Create(TRIGGER_CLEANUP106);
                    		adaptor.AddChild(root_0, TRIGGER_CLEANUP106_tree);

                    	char_literal107=(IToken)Match(input,70,FOLLOW_70_in_trigger2645); 
                    		char_literal107_tree = (object)adaptor.Create(char_literal107);
                    		adaptor.AddChild(root_0, char_literal107_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2649);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal108=(IToken)Match(input,71,FOLLOW_71_in_trigger2651); 
                    		char_literal108_tree = (object)adaptor.Create(char_literal108);
                    		adaptor.AddChild(root_0, char_literal108_tree);

                    	 retval.t =  new CleanupTrigger(((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:507:4: TRIGGER_TIME '(' time= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_TIME109=(IToken)Match(input,TRIGGER_TIME,FOLLOW_TRIGGER_TIME_in_trigger2684); 
                    		TRIGGER_TIME109_tree = (object)adaptor.Create(TRIGGER_TIME109);
                    		adaptor.AddChild(root_0, TRIGGER_TIME109_tree);

                    	char_literal110=(IToken)Match(input,59,FOLLOW_59_in_trigger2686); 
                    		char_literal110_tree = (object)adaptor.Create(char_literal110);
                    		adaptor.AddChild(root_0, char_literal110_tree);

                    	time=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2690); 
                    		time_tree = (object)adaptor.Create(time);
                    		adaptor.AddChild(root_0, time_tree);

                    	char_literal111=(IToken)Match(input,61,FOLLOW_61_in_trigger2692); 
                    		char_literal111_tree = (object)adaptor.Create(char_literal111);
                    		adaptor.AddChild(root_0, char_literal111_tree);

                    	char_literal112=(IToken)Match(input,70,FOLLOW_70_in_trigger2694); 
                    		char_literal112_tree = (object)adaptor.Create(char_literal112);
                    		adaptor.AddChild(root_0, char_literal112_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2698);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal113=(IToken)Match(input,71,FOLLOW_71_in_trigger2700); 
                    		char_literal113_tree = (object)adaptor.Create(char_literal113);
                    		adaptor.AddChild(root_0, char_literal113_tree);

                    	 retval.t =  new TimeTrigger(float.Parse(time.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:508:4: TRIGGER_PERIODIC '(' period= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_PERIODIC114=(IToken)Match(input,TRIGGER_PERIODIC,FOLLOW_TRIGGER_PERIODIC_in_trigger2716); 
                    		TRIGGER_PERIODIC114_tree = (object)adaptor.Create(TRIGGER_PERIODIC114);
                    		adaptor.AddChild(root_0, TRIGGER_PERIODIC114_tree);

                    	char_literal115=(IToken)Match(input,59,FOLLOW_59_in_trigger2718); 
                    		char_literal115_tree = (object)adaptor.Create(char_literal115);
                    		adaptor.AddChild(root_0, char_literal115_tree);

                    	period=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2722); 
                    		period_tree = (object)adaptor.Create(period);
                    		adaptor.AddChild(root_0, period_tree);

                    	char_literal116=(IToken)Match(input,61,FOLLOW_61_in_trigger2724); 
                    		char_literal116_tree = (object)adaptor.Create(char_literal116);
                    		adaptor.AddChild(root_0, char_literal116_tree);

                    	char_literal117=(IToken)Match(input,70,FOLLOW_70_in_trigger2726); 
                    		char_literal117_tree = (object)adaptor.Create(char_literal117);
                    		adaptor.AddChild(root_0, char_literal117_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2730);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal118=(IToken)Match(input,71,FOLLOW_71_in_trigger2732); 
                    		char_literal118_tree = (object)adaptor.Create(char_literal118);
                    		adaptor.AddChild(root_0, char_literal118_tree);

                    	 retval.t =  new PeriodicTrigger(float.Parse(period.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:509:4: TRIGGER_SCROLLING '(' scroll= NUMBER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_SCROLLING119=(IToken)Match(input,TRIGGER_SCROLLING,FOLLOW_TRIGGER_SCROLLING_in_trigger2739); 
                    		TRIGGER_SCROLLING119_tree = (object)adaptor.Create(TRIGGER_SCROLLING119);
                    		adaptor.AddChild(root_0, TRIGGER_SCROLLING119_tree);

                    	char_literal120=(IToken)Match(input,59,FOLLOW_59_in_trigger2741); 
                    		char_literal120_tree = (object)adaptor.Create(char_literal120);
                    		adaptor.AddChild(root_0, char_literal120_tree);

                    	scroll=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_trigger2745); 
                    		scroll_tree = (object)adaptor.Create(scroll);
                    		adaptor.AddChild(root_0, scroll_tree);

                    	char_literal121=(IToken)Match(input,61,FOLLOW_61_in_trigger2747); 
                    		char_literal121_tree = (object)adaptor.Create(char_literal121);
                    		adaptor.AddChild(root_0, char_literal121_tree);

                    	char_literal122=(IToken)Match(input,70,FOLLOW_70_in_trigger2749); 
                    		char_literal122_tree = (object)adaptor.Create(char_literal122);
                    		adaptor.AddChild(root_0, char_literal122_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2753);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal123=(IToken)Match(input,71,FOLLOW_71_in_trigger2755); 
                    		char_literal123_tree = (object)adaptor.Create(char_literal123);
                    		adaptor.AddChild(root_0, char_literal123_tree);

                    	 retval.t =  new ScrollingTrigger(float.Parse(scroll.Text), ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:510:4: TRIGGER_ANIMATION_END '(' anim= STRING ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_ANIMATION_END124=(IToken)Match(input,TRIGGER_ANIMATION_END,FOLLOW_TRIGGER_ANIMATION_END_in_trigger2764); 
                    		TRIGGER_ANIMATION_END124_tree = (object)adaptor.Create(TRIGGER_ANIMATION_END124);
                    		adaptor.AddChild(root_0, TRIGGER_ANIMATION_END124_tree);

                    	char_literal125=(IToken)Match(input,59,FOLLOW_59_in_trigger2766); 
                    		char_literal125_tree = (object)adaptor.Create(char_literal125);
                    		adaptor.AddChild(root_0, char_literal125_tree);

                    	anim=(IToken)Match(input,STRING,FOLLOW_STRING_in_trigger2770); 
                    		anim_tree = (object)adaptor.Create(anim);
                    		adaptor.AddChild(root_0, anim_tree);

                    	char_literal126=(IToken)Match(input,61,FOLLOW_61_in_trigger2772); 
                    		char_literal126_tree = (object)adaptor.Create(char_literal126);
                    		adaptor.AddChild(root_0, char_literal126_tree);

                    	char_literal127=(IToken)Match(input,70,FOLLOW_70_in_trigger2774); 
                    		char_literal127_tree = (object)adaptor.Create(char_literal127);
                    		adaptor.AddChild(root_0, char_literal127_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2778);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal128=(IToken)Match(input,71,FOLLOW_71_in_trigger2780); 
                    		char_literal128_tree = (object)adaptor.Create(char_literal128);
                    		adaptor.AddChild(root_0, char_literal128_tree);

                    	 retval.t =  new AnimationEndTrigger(anim.Text, ((a != null) ? a.actions : default(List<Action>))); 

                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:511:4: TRIGGER_EVENT '(' e= CLASS_IDENTIFIER ')' '{' a= action_list '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRIGGER_EVENT129=(IToken)Match(input,TRIGGER_EVENT,FOLLOW_TRIGGER_EVENT_in_trigger2787); 
                    		TRIGGER_EVENT129_tree = (object)adaptor.Create(TRIGGER_EVENT129);
                    		adaptor.AddChild(root_0, TRIGGER_EVENT129_tree);

                    	char_literal130=(IToken)Match(input,59,FOLLOW_59_in_trigger2789); 
                    		char_literal130_tree = (object)adaptor.Create(char_literal130);
                    		adaptor.AddChild(root_0, char_literal130_tree);

                    	e=(IToken)Match(input,CLASS_IDENTIFIER,FOLLOW_CLASS_IDENTIFIER_in_trigger2793); 
                    		e_tree = (object)adaptor.Create(e);
                    		adaptor.AddChild(root_0, e_tree);

                    	char_literal131=(IToken)Match(input,61,FOLLOW_61_in_trigger2795); 
                    		char_literal131_tree = (object)adaptor.Create(char_literal131);
                    		adaptor.AddChild(root_0, char_literal131_tree);

                    	char_literal132=(IToken)Match(input,70,FOLLOW_70_in_trigger2797); 
                    		char_literal132_tree = (object)adaptor.Create(char_literal132);
                    		adaptor.AddChild(root_0, char_literal132_tree);

                    	PushFollow(FOLLOW_action_list_in_trigger2801);
                    	a = action_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, a.Tree);
                    	char_literal133=(IToken)Match(input,71,FOLLOW_71_in_trigger2803); 
                    		char_literal133_tree = (object)adaptor.Create(char_literal133);
                    		adaptor.AddChild(root_0, char_literal133_tree);

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
        "\x0c\uffff";
    const string DFA6_eofS =
        "\x0c\uffff";
    const string DFA6_minS =
        "\x01\x25\x01\x04\x0a\uffff";
    const string DFA6_maxS =
        "\x01\x3b\x01\x47\x0a\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01"+
        "\x09\x01\x0a\x01\x02\x01\x01";
    const string DFA6_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x06\x01\x07\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff"+
            "\x01\x08\x04\uffff\x01\x01\x09\uffff\x01\x09",
            "\x01\x0b\x07\uffff\x12\x0b\x0d\uffff\x02\x0b\x0f\uffff\x07"+
            "\x0b\x01\x0a\x03\uffff\x01\x0b",
            "",
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
            get { return "315:1: simple_formula returns [Formula f] : (c= NUMBER | c= NUMBER '°' | CONST_ANGLE_DOWN | CONST_ANGLE_UP | CONST_ANGLE_LEFT | CONST_ANGLE_RIGHT | PREDEF_ANGLE_TOWARD_PLAYER | PREDEF_ANGLE_CURRENT | v= VARIABLE | '(' sf= formula ')' );"; }
        }

    }

    const string DFA19_eotS =
        "\x0d\uffff";
    const string DFA19_eofS =
        "\x0d\uffff";
    const string DFA19_minS =
        "\x01\x04\x01\x14\x01\uffff\x01\x14\x09\uffff";
    const string DFA19_maxS =
        "\x01\x2c\x01\x1d\x01\uffff\x01\x1d\x09\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a";
    const string DFA19_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x01\x07\uffff\x08\x0b\x01\x04\x01\x05\x01\x06\x01\x07"+
            "\x01\x08\x01\x09\x01\x0a\x01\x02\x01\x0b\x01\x0c\x0d\uffff\x01"+
            "\x03\x01\x0b",
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
            get { return "450:1: action : (pla= play_animation_action | pa= periodic_action | fap= fire_action | fam= fire_multiple_action | da= die_action | sta= start_action | sa= stop_action | sum= summon_action | sea= set_action | raa= raise_action );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_classdef_in_gbs1007 = new BitSet(new ulong[]{0x0000000000000FE2UL});
    public static readonly BitSet FOLLOW_circle_shape_in_shape1027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SHAPE_CIRCLE_in_circle_shape1045 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_circle_shape1047 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_circle_shape1051 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_circle_shape1053 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_circle_shape1057 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_circle_shape1059 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_circle_shape1063 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_circle_shape1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula1096 = new BitSet(new ulong[]{0xC000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_formula1102 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_63_in_formula1108 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_factor_formula_in_formula1116 = new BitSet(new ulong[]{0xC000000000000002UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1153 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_64_in_factor_formula1159 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_65_in_factor_formula1165 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_66_in_factor_formula1171 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_simple_formula_in_factor_formula1179 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_simple_formula1212 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_simple_formula1214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_DOWN_in_simple_formula1221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_UP_in_simple_formula1228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_LEFT_in_simple_formula1235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONST_ANGLE_RIGHT_in_simple_formula1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_TOWARD_PLAYER_in_simple_formula1249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PREDEF_ANGLE_CURRENT_in_simple_formula1256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_simple_formula1265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_simple_formula1272 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_simple_formula1276 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_simple_formula1278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_range1298 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_range1300 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_range1304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fps_param_in_param1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gamearea_param_in_param1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_position_param_in_param1350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_speed_param_in_param1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_animation_param_in_param1375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_color_param_in_param1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scrolling_param_in_param1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trajectory_param_in_param1408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_custom_param_in_param1417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_FPS_in_fps_param1437 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_fps_param1439 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_fps_param1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_GAMEAREA_in_gamearea_param1460 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_gamearea_param1462 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RECTANGLE_in_gamearea_param1466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_POSITION_in_position_param1484 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_position_param1486 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_POINT_in_position_param1490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SPEED_in_speed_param1508 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_speed_param1510 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_speed_param1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_ANIMATION_in_animation_param1532 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_animation_param1534 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_animation_param1538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_COLOR_in_color_param1556 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_color_param1558 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_color_param1562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_SCROLLING_in_scrolling_param1580 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_scrolling_param1582 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_DIRECTION_in_scrolling_param1586 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_scrolling_param1588 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scrolling_param1592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_TRAJECTORY_in_trajectory_param1609 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_trajectory_param1611 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_shape_in_trajectory_param1615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_custom_param1634 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_custom_param1636 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_custom_param1640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_engine_classdef_in_classdef1671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_player_classdef_in_classdef1680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bullet_classdef_in_classdef1689 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enemy_classdef_in_classdef1698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_event_classdef_in_classdef1707 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_state_classdef_in_classdef1716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_script_classdef_in_classdef1725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_trigger_in_classdef_content1740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classdef_in_classdef_content1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENGINE_in_engine_classdef1781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_engine_classdef1783 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_engine_classdef1785 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_engine_classdef1788 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_PLAYER_in_player_classdef1806 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_player_classdef1810 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_player_classdef1812 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_player_classdef1814 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_player_classdef1817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_ENEMY_in_enemy_classdef1834 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_enemy_classdef1838 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_enemy_classdef1840 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_enemy_classdef1842 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_enemy_classdef1845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_BULLET_in_bullet_classdef1862 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_bullet_classdef1866 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_bullet_classdef1868 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_bullet_classdef1870 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_bullet_classdef1873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_SCRIPT_in_script_classdef1891 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_script_classdef1895 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_script_classdef1897 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_script_classdef1899 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_script_classdef1902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_STATE_in_state_classdef1919 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_state_classdef1923 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_state_classdef1925 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_classdef_content_in_state_classdef1927 = new BitSet(new ulong[]{0x0000001FC0000FE0UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_state_classdef1930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CLASSDEF_EVENT_in_event_classdef1949 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_event_classdef1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_in_action_list1982 = new BitSet(new ulong[]{0x000018003FFFF012UL});
    public static readonly BitSet FOLLOW_THIS_in_action_target2000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_action_target2030 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_play_animation_action_in_action2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_periodic_action_in_action2054 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_action_in_action2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fire_multiple_action_in_action2084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_die_action_in_action2094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_start_action_in_action2115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stop_action_in_action2133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_summon_action_in_action2153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_action_in_action2170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_raise_action_in_action2190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_play_animation_action2212 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ACTION_PLAY_ANIMATION_in_play_animation_action2214 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_play_animation_action2216 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_play_animation_action2220 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_play_animation_action2222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_periodic_action2242 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ACTION_PERIODIC_in_periodic_action2244 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_periodic_action2246 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_periodic_action2250 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_periodic_action2252 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_periodic_action2254 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_periodic_action2258 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_periodic_action2260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_action2280 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_in_fire_action2282 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_fire_action2284 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_action2288 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_fire_action2290 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_action2294 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_fire_action2296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_fire_multiple_action2315 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_ACTION_FIRE_MULTIPLE_in_fire_multiple_action2317 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_fire_multiple_action2319 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_fire_multiple_action2323 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_fire_multiple_action2325 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_multiple_action2329 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_fire_multiple_action2331 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_range_in_fire_multiple_action2335 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_fire_multiple_action2337 = new BitSet(new ulong[]{0x080217E000000000UL});
    public static readonly BitSet FOLLOW_formula_in_fire_multiple_action2341 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_fire_multiple_action2343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_die_action2363 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_ACTION_DIE_in_die_action2365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_start_action2385 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ACTION_START_in_start_action2387 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_start_action2389 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_start_action2393 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_start_action2395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_stop_action2414 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ACTION_STOP_in_stop_action2416 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_stop_action2418 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_stop_action2422 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_stop_action2424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_summon_action2445 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ACTION_SUMMON_in_summon_action2447 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_summon_action2449 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_summon_action2453 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_summon_action2455 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_INSTANCE_IDENTIFIER_in_summon_action2459 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_summon_action2463 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_summon_action2467 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_summon_action2469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_set_action2492 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_ACTION_SET_in_set_action2494 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_set_action2496 = new BitSet(new ulong[]{0x00001800100FF010UL});
    public static readonly BitSet FOLLOW_param_in_set_action2500 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_set_action2502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_in_set_action2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_action_target_in_raise_action2571 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_ACTION_RAISE_in_raise_action2573 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_raise_action2575 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_raise_action2579 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_raise_action2581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_INIT_in_trigger2599 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2601 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2605 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_CLEANUP_in_trigger2643 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2645 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_TIME_in_trigger2684 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2686 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2690 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2692 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2694 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2698 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_PERIODIC_in_trigger2716 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2718 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2722 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2724 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2726 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2730 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_SCROLLING_in_trigger2739 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2741 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_trigger2745 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2747 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2749 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2753 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_ANIMATION_END_in_trigger2764 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2766 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_trigger2770 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2772 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2774 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2778 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2780 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRIGGER_EVENT_in_trigger2787 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_trigger2789 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_CLASS_IDENTIFIER_in_trigger2793 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_trigger2795 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_trigger2797 = new BitSet(new ulong[]{0x000018003FFFF010UL});
    public static readonly BitSet FOLLOW_action_list_in_trigger2801 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_trigger2803 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}