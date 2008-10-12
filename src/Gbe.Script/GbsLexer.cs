// $ANTLR 3.1.1 C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g 2008-10-12 22:23:54
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  
	Gbe.Script 

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class GbsLexer : Lexer {
    public const int DIRECTION = 39;
    public const int ACTION_SET = 26;
    public const int POINT = 41;
    public const int TRIGGER_SCROLLING = 32;
    public const int CLASSDEF_SCRIPT = 9;
    public const int EOF = -1;
    public const int PARAM_SCROLLING = 18;
    public const int COLOR = 36;
    public const int TRIGGER_CLEANUP = 29;
    public const int CLASSDEF_BULLET = 7;
    public const int ML_COMMENT = 47;
    public const int PARAM_ANIMATION = 17;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int INSTANCE_IDENTIFIER = 44;
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

    public GbsLexer() 
    {
		InitializeCyclicDFAs();
    }
    public GbsLexer(ICharStream input)
		: this(input, null) {
    }
    public GbsLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g";} 
    }

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:11:7: ( '=' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:11:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:12:7: ( ',' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:12:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:13:7: ( '{' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:13:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:14:7: ( '}' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:14:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:15:7: ( '(' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:15:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:16:7: ( ')' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:16:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "THIS"
    public void mTHIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THIS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:32:2: ( 'this' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:32:4: 'this'
            {
            	Match("this"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THIS"

    // $ANTLR start "CLASSDEF_ENGINE"
    public void mCLASSDEF_ENGINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_ENGINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:36:2: ( 'ENGINE' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:36:4: 'ENGINE'
            {
            	Match("ENGINE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_ENGINE"

    // $ANTLR start "CLASSDEF_PLAYER"
    public void mCLASSDEF_PLAYER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_PLAYER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:40:2: ( 'PLAYER' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:40:4: 'PLAYER'
            {
            	Match("PLAYER"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_PLAYER"

    // $ANTLR start "CLASSDEF_BULLET"
    public void mCLASSDEF_BULLET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_BULLET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:44:2: ( 'BULLET' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:44:4: 'BULLET'
            {
            	Match("BULLET"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_BULLET"

    // $ANTLR start "CLASSDEF_ENEMY"
    public void mCLASSDEF_ENEMY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_ENEMY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:48:2: ( 'ENEMY' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:48:4: 'ENEMY'
            {
            	Match("ENEMY"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_ENEMY"

    // $ANTLR start "CLASSDEF_SCRIPT"
    public void mCLASSDEF_SCRIPT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_SCRIPT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:52:2: ( 'SCRIPT' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:52:4: 'SCRIPT'
            {
            	Match("SCRIPT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_SCRIPT"

    // $ANTLR start "CLASSDEF_STATE"
    public void mCLASSDEF_STATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_STATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:56:2: ( 'STATE' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:56:4: 'STATE'
            {
            	Match("STATE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_STATE"

    // $ANTLR start "CLASSDEF_EVENT"
    public void mCLASSDEF_EVENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSDEF_EVENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:60:2: ( 'EVENT' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:60:4: 'EVENT'
            {
            	Match("EVENT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSDEF_EVENT"

    // $ANTLR start "PARAM_FPS"
    public void mPARAM_FPS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_FPS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:64:2: ( 'fps' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:64:4: 'fps'
            {
            	Match("fps"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_FPS"

    // $ANTLR start "PARAM_GAMEAREA"
    public void mPARAM_GAMEAREA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_GAMEAREA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:68:2: ( 'gameArea' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:68:4: 'gameArea'
            {
            	Match("gameArea"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_GAMEAREA"

    // $ANTLR start "PARAM_POSITION"
    public void mPARAM_POSITION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_POSITION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:72:2: ( 'position' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:72:4: 'position'
            {
            	Match("position"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_POSITION"

    // $ANTLR start "PARAM_COLOR"
    public void mPARAM_COLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:76:2: ( 'color' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:76:4: 'color'
            {
            	Match("color"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_COLOR"

    // $ANTLR start "PARAM_SPEED"
    public void mPARAM_SPEED() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_SPEED;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:80:2: ( 'speed' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:80:4: 'speed'
            {
            	Match("speed"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_SPEED"

    // $ANTLR start "PARAM_ANIMATION"
    public void mPARAM_ANIMATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_ANIMATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:84:2: ( 'animation' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:84:4: 'animation'
            {
            	Match("animation"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_ANIMATION"

    // $ANTLR start "PARAM_SCROLLING"
    public void mPARAM_SCROLLING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM_SCROLLING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:88:2: ( 'scrolling' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:88:4: 'scrolling'
            {
            	Match("scrolling"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM_SCROLLING"

    // $ANTLR start "ACTION_PERIODIC"
    public void mACTION_PERIODIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_PERIODIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:92:2: ( '.periodic' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:92:4: '.periodic'
            {
            	Match(".periodic"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_PERIODIC"

    // $ANTLR start "ACTION_FIRE_AT_PLAYER"
    public void mACTION_FIRE_AT_PLAYER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_FIRE_AT_PLAYER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:96:2: ( '.fireAtPlayer' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:96:4: '.fireAtPlayer'
            {
            	Match(".fireAtPlayer"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_FIRE_AT_PLAYER"

    // $ANTLR start "ACTION_DIE"
    public void mACTION_DIE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_DIE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:100:2: ( '.die' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:100:4: '.die'
            {
            	Match(".die"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_DIE"

    // $ANTLR start "ACTION_START"
    public void mACTION_START() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_START;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:104:2: ( '.start' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:104:4: '.start'
            {
            	Match(".start"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_START"

    // $ANTLR start "ACTION_STOP"
    public void mACTION_STOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_STOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:108:2: ( '.stop' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:108:4: '.stop'
            {
            	Match(".stop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_STOP"

    // $ANTLR start "ACTION_SUMMON"
    public void mACTION_SUMMON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_SUMMON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:112:2: ( '.summon' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:112:4: '.summon'
            {
            	Match(".summon"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_SUMMON"

    // $ANTLR start "ACTION_PLAY_ANIMATION"
    public void mACTION_PLAY_ANIMATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_PLAY_ANIMATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:116:2: ( '.playAnimation' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:116:4: '.playAnimation'
            {
            	Match(".playAnimation"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_PLAY_ANIMATION"

    // $ANTLR start "ACTION_SET"
    public void mACTION_SET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_SET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:120:2: ( '.set' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:120:4: '.set'
            {
            	Match(".set"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_SET"

    // $ANTLR start "ACTION_RAISE"
    public void mACTION_RAISE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION_RAISE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:124:2: ( '.raise' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:124:4: '.raise'
            {
            	Match(".raise"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_RAISE"

    // $ANTLR start "TRIGGER_INIT"
    public void mTRIGGER_INIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_INIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:128:2: ( '@init' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:128:4: '@init'
            {
            	Match("@init"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_INIT"

    // $ANTLR start "TRIGGER_CLEANUP"
    public void mTRIGGER_CLEANUP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_CLEANUP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:132:2: ( '@cleanup' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:132:4: '@cleanup'
            {
            	Match("@cleanup"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_CLEANUP"

    // $ANTLR start "TRIGGER_TIME"
    public void mTRIGGER_TIME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_TIME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:136:2: ( '@time' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:136:4: '@time'
            {
            	Match("@time"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_TIME"

    // $ANTLR start "TRIGGER_PERIODIC"
    public void mTRIGGER_PERIODIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_PERIODIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:140:2: ( '@periodic' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:140:4: '@periodic'
            {
            	Match("@periodic"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_PERIODIC"

    // $ANTLR start "TRIGGER_SCROLLING"
    public void mTRIGGER_SCROLLING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_SCROLLING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:144:2: ( '@scrolling' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:144:4: '@scrolling'
            {
            	Match("@scrolling"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_SCROLLING"

    // $ANTLR start "TRIGGER_ANIMATION_END"
    public void mTRIGGER_ANIMATION_END() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_ANIMATION_END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:148:2: ( '@animationEnd' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:148:4: '@animationEnd'
            {
            	Match("@animationEnd"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_ANIMATION_END"

    // $ANTLR start "TRIGGER_EVENT"
    public void mTRIGGER_EVENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGGER_EVENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:152:2: ( '@event' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:152:4: '@event'
            {
            	Match("@event"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGGER_EVENT"

    // $ANTLR start "COLOR"
    public void mCOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:156:2: ( 'black' | 'white' | 'red' | 'green' | 'blue' | 'yellow' | 'pink' | 'lightblue' | '#' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            int alt1 = 9;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:156:4: 'black'
                    {
                    	Match("black"); 


                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:157:4: 'white'
                    {
                    	Match("white"); 


                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:158:4: 'red'
                    {
                    	Match("red"); 


                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:159:4: 'green'
                    {
                    	Match("green"); 


                    }
                    break;
                case 5 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:160:4: 'blue'
                    {
                    	Match("blue"); 


                    }
                    break;
                case 6 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:161:4: 'yellow'
                    {
                    	Match("yellow"); 


                    }
                    break;
                case 7 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:162:4: 'pink'
                    {
                    	Match("pink"); 


                    }
                    break;
                case 8 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:163:4: 'lightblue'
                    {
                    	Match("lightblue"); 


                    }
                    break;
                case 9 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:164:4: '#' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('#'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLOR"

    // $ANTLR start "DIRECTION"
    public void mDIRECTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIRECTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:168:2: ( CARDINAL_DIRECTION ( ( '+' | '-' ) NUMBER )? )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:168:4: CARDINAL_DIRECTION ( ( '+' | '-' ) NUMBER )?
            {
            	mCARDINAL_DIRECTION(); 
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:168:23: ( ( '+' | '-' ) NUMBER )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '+' || LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:168:25: ( '+' | '-' ) NUMBER
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}

            	        	mNUMBER(); 

            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIRECTION"

    // $ANTLR start "CARDINAL_DIRECTION"
    public void mCARDINAL_DIRECTION() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:172:2: ( 'up' | 'down' | 'left' | 'right' )
            int alt3 = 4;
            switch ( input.LA(1) ) 
            {
            case 'u':
            	{
                alt3 = 1;
                }
                break;
            case 'd':
            	{
                alt3 = 2;
                }
                break;
            case 'l':
            	{
                alt3 = 3;
                }
                break;
            case 'r':
            	{
                alt3 = 4;
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
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:172:4: 'up'
                    {
                    	Match("up"); 


                    }
                    break;
                case 2 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:173:4: 'down'
                    {
                    	Match("down"); 


                    }
                    break;
                case 3 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:174:4: 'left'
                    {
                    	Match("left"); 


                    }
                    break;
                case 4 :
                    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:175:4: 'right'
                    {
                    	Match("right"); 


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CARDINAL_DIRECTION"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:2: ( ( '+' | '-' )? ( ( ( DIGIT )+ ( '.' ( DIGIT )* )? ) | ( '.' ( DIGIT )+ ) ) )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:4: ( '+' | '-' )? ( ( ( DIGIT )+ ( '.' ( DIGIT )* )? ) | ( '.' ( DIGIT )+ ) )
            {
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:4: ( '+' | '-' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '+' || LA4_0 == '-') )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:19: ( ( ( DIGIT )+ ( '.' ( DIGIT )* )? ) | ( '.' ( DIGIT )+ ) )
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
            	{
            	    alt9 = 1;
            	}
            	else if ( (LA9_0 == '.') )
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
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:21: ( ( DIGIT )+ ( '.' ( DIGIT )* )? )
            	        {
            	        	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:21: ( ( DIGIT )+ ( '.' ( DIGIT )* )? )
            	        	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:23: ( DIGIT )+ ( '.' ( DIGIT )* )?
            	        	{
            	        		// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:23: ( DIGIT )+
            	        		int cnt5 = 0;
            	        		do 
            	        		{
            	        		    int alt5 = 2;
            	        		    int LA5_0 = input.LA(1);

            	        		    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	        		    {
            	        		        alt5 = 1;
            	        		    }


            	        		    switch (alt5) 
            	        			{
            	        				case 1 :
            	        				    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:23: DIGIT
            	        				    {
            	        				    	mDIGIT(); 

            	        				    }
            	        				    break;

            	        				default:
            	        				    if ( cnt5 >= 1 ) goto loop5;
            	        			            EarlyExitException eee =
            	        			                new EarlyExitException(5, input);
            	        			            throw eee;
            	        		    }
            	        		    cnt5++;
            	        		} while (true);

            	        		loop5:
            	        			;	// Stops C# compiler whinging that label 'loop5' has no statements

            	        		// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:30: ( '.' ( DIGIT )* )?
            	        		int alt7 = 2;
            	        		int LA7_0 = input.LA(1);

            	        		if ( (LA7_0 == '.') )
            	        		{
            	        		    alt7 = 1;
            	        		}
            	        		switch (alt7) 
            	        		{
            	        		    case 1 :
            	        		        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:32: '.' ( DIGIT )*
            	        		        {
            	        		        	Match('.'); 
            	        		        	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:36: ( DIGIT )*
            	        		        	do 
            	        		        	{
            	        		        	    int alt6 = 2;
            	        		        	    int LA6_0 = input.LA(1);

            	        		        	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	        		        	    {
            	        		        	        alt6 = 1;
            	        		        	    }


            	        		        	    switch (alt6) 
            	        		        		{
            	        		        			case 1 :
            	        		        			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:36: DIGIT
            	        		        			    {
            	        		        			    	mDIGIT(); 

            	        		        			    }
            	        		        			    break;

            	        		        			default:
            	        		        			    goto loop6;
            	        		        	    }
            	        		        	} while (true);

            	        		        	loop6:
            	        		        		;	// Stops C# compiler whining that label 'loop6' has no statements


            	        		        }
            	        		        break;

            	        		}


            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:50: ( '.' ( DIGIT )+ )
            	        {
            	        	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:50: ( '.' ( DIGIT )+ )
            	        	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:52: '.' ( DIGIT )+
            	        	{
            	        		Match('.'); 
            	        		// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:56: ( DIGIT )+
            	        		int cnt8 = 0;
            	        		do 
            	        		{
            	        		    int alt8 = 2;
            	        		    int LA8_0 = input.LA(1);

            	        		    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            	        		    {
            	        		        alt8 = 1;
            	        		    }


            	        		    switch (alt8) 
            	        			{
            	        				case 1 :
            	        				    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:179:56: DIGIT
            	        				    {
            	        				    	mDIGIT(); 

            	        				    }
            	        				    break;

            	        				default:
            	        				    if ( cnt8 >= 1 ) goto loop8;
            	        			            EarlyExitException eee =
            	        			                new EarlyExitException(8, input);
            	        			            throw eee;
            	        		    }
            	        		    cnt8++;
            	        		} while (true);

            	        		loop8:
            	        			;	// Stops C# compiler whinging that label 'loop8' has no statements


            	        	}


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:183:2: ( DIGIT | 'A' .. 'F' | 'a' .. 'f' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:187:2: ( '0' .. '9' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:187:4: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "POINT"
    public void mPOINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = POINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:191:2: ( NUMBER ':' NUMBER )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:191:4: NUMBER ':' NUMBER
            {
            	mNUMBER(); 
            	Match(':'); 
            	mNUMBER(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "POINT"

    // $ANTLR start "RECTANGLE"
    public void mRECTANGLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RECTANGLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:195:2: ( POINT '->' POINT )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:195:4: POINT '->' POINT
            {
            	mPOINT(); 
            	Match("->"); 

            	mPOINT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RECTANGLE"

    // $ANTLR start "CLASS_IDENTIFIER"
    public void mCLASS_IDENTIFIER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASS_IDENTIFIER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:199:2: ( 'A' .. 'Z' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:199:4: 'A' .. 'Z' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            {
            	MatchRange('A','Z'); 
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:199:13: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '0' && LA10_0 <= '9') || (LA10_0 >= 'A' && LA10_0 <= 'Z') || (LA10_0 >= 'a' && LA10_0 <= 'z')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASS_IDENTIFIER"

    // $ANTLR start "INSTANCE_IDENTIFIER"
    public void mINSTANCE_IDENTIFIER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INSTANCE_IDENTIFIER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:203:2: ( 'a' .. 'z' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:203:4: 'a' .. 'z' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            {
            	MatchRange('a','z'); 
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:203:13: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= '0' && LA11_0 <= '9') || (LA11_0 >= 'A' && LA11_0 <= 'Z') || (LA11_0 >= 'a' && LA11_0 <= 'z')) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INSTANCE_IDENTIFIER"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:207:2: ( '\"' ( options {greedy=false; } : . )* '\"' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:207:4: '\"' ( options {greedy=false; } : . )* '\"'
            {
            	Match('\"'); 
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:207:8: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == '\"') )
            	    {
            	        alt12 = 2;
            	    }
            	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= '!') || (LA12_0 >= '#' && LA12_0 <= '\uFFFF')) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:207:38: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:211:2: ( ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+ )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:211:4: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            {
            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:211:4: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '\t' && LA13_0 <= '\n') || (LA13_0 >= '\f' && LA13_0 <= '\r') || LA13_0 == ' ') )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee =
            		                new EarlyExitException(13, input);
            		            throw eee;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whinging that label 'loop13' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "ML_COMMENT"
    public void mML_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ML_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:215:2: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:215:4: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:215:9: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == '*') )
            	    {
            	        int LA14_1 = input.LA(2);

            	        if ( (LA14_1 == '/') )
            	        {
            	            alt14 = 2;
            	        }
            	        else if ( ((LA14_1 >= '\u0000' && LA14_1 <= '.') || (LA14_1 >= '0' && LA14_1 <= '\uFFFF')) )
            	        {
            	            alt14 = 1;
            	        }


            	    }
            	    else if ( ((LA14_0 >= '\u0000' && LA14_0 <= ')') || (LA14_0 >= '+' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:215:39: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	Match("*/"); 

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ML_COMMENT"

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:219:2: ( '//' ( options {greedy=false; } : . )* '\\n' )
            // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:219:4: '//' ( options {greedy=false; } : . )* '\\n'
            {
            	Match("//"); 

            	// C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:219:9: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == '\n') )
            	    {
            	        alt15 = 2;
            	    }
            	    else if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\t') || (LA15_0 >= '\u000B' && LA15_0 <= '\uFFFF')) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:219:39: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	Match('\n'); 
            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SL_COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:8: ( T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | THIS | CLASSDEF_ENGINE | CLASSDEF_PLAYER | CLASSDEF_BULLET | CLASSDEF_ENEMY | CLASSDEF_SCRIPT | CLASSDEF_STATE | CLASSDEF_EVENT | PARAM_FPS | PARAM_GAMEAREA | PARAM_POSITION | PARAM_COLOR | PARAM_SPEED | PARAM_ANIMATION | PARAM_SCROLLING | ACTION_PERIODIC | ACTION_FIRE_AT_PLAYER | ACTION_DIE | ACTION_START | ACTION_STOP | ACTION_SUMMON | ACTION_PLAY_ANIMATION | ACTION_SET | ACTION_RAISE | TRIGGER_INIT | TRIGGER_CLEANUP | TRIGGER_TIME | TRIGGER_PERIODIC | TRIGGER_SCROLLING | TRIGGER_ANIMATION_END | TRIGGER_EVENT | COLOR | DIRECTION | NUMBER | POINT | RECTANGLE | CLASS_IDENTIFIER | INSTANCE_IDENTIFIER | STRING | WHITESPACE | ML_COMMENT | SL_COMMENT )
        int alt16 = 48;
        alt16 = dfa16.Predict(input);
        switch (alt16) 
        {
            case 1 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:10: T__49
                {
                	mT__49(); 

                }
                break;
            case 2 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:16: T__50
                {
                	mT__50(); 

                }
                break;
            case 3 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:22: T__51
                {
                	mT__51(); 

                }
                break;
            case 4 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:28: T__52
                {
                	mT__52(); 

                }
                break;
            case 5 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:34: T__53
                {
                	mT__53(); 

                }
                break;
            case 6 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:40: T__54
                {
                	mT__54(); 

                }
                break;
            case 7 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:46: THIS
                {
                	mTHIS(); 

                }
                break;
            case 8 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:51: CLASSDEF_ENGINE
                {
                	mCLASSDEF_ENGINE(); 

                }
                break;
            case 9 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:67: CLASSDEF_PLAYER
                {
                	mCLASSDEF_PLAYER(); 

                }
                break;
            case 10 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:83: CLASSDEF_BULLET
                {
                	mCLASSDEF_BULLET(); 

                }
                break;
            case 11 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:99: CLASSDEF_ENEMY
                {
                	mCLASSDEF_ENEMY(); 

                }
                break;
            case 12 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:114: CLASSDEF_SCRIPT
                {
                	mCLASSDEF_SCRIPT(); 

                }
                break;
            case 13 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:130: CLASSDEF_STATE
                {
                	mCLASSDEF_STATE(); 

                }
                break;
            case 14 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:145: CLASSDEF_EVENT
                {
                	mCLASSDEF_EVENT(); 

                }
                break;
            case 15 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:160: PARAM_FPS
                {
                	mPARAM_FPS(); 

                }
                break;
            case 16 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:170: PARAM_GAMEAREA
                {
                	mPARAM_GAMEAREA(); 

                }
                break;
            case 17 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:185: PARAM_POSITION
                {
                	mPARAM_POSITION(); 

                }
                break;
            case 18 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:200: PARAM_COLOR
                {
                	mPARAM_COLOR(); 

                }
                break;
            case 19 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:212: PARAM_SPEED
                {
                	mPARAM_SPEED(); 

                }
                break;
            case 20 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:224: PARAM_ANIMATION
                {
                	mPARAM_ANIMATION(); 

                }
                break;
            case 21 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:240: PARAM_SCROLLING
                {
                	mPARAM_SCROLLING(); 

                }
                break;
            case 22 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:256: ACTION_PERIODIC
                {
                	mACTION_PERIODIC(); 

                }
                break;
            case 23 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:272: ACTION_FIRE_AT_PLAYER
                {
                	mACTION_FIRE_AT_PLAYER(); 

                }
                break;
            case 24 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:294: ACTION_DIE
                {
                	mACTION_DIE(); 

                }
                break;
            case 25 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:305: ACTION_START
                {
                	mACTION_START(); 

                }
                break;
            case 26 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:318: ACTION_STOP
                {
                	mACTION_STOP(); 

                }
                break;
            case 27 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:330: ACTION_SUMMON
                {
                	mACTION_SUMMON(); 

                }
                break;
            case 28 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:344: ACTION_PLAY_ANIMATION
                {
                	mACTION_PLAY_ANIMATION(); 

                }
                break;
            case 29 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:366: ACTION_SET
                {
                	mACTION_SET(); 

                }
                break;
            case 30 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:377: ACTION_RAISE
                {
                	mACTION_RAISE(); 

                }
                break;
            case 31 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:390: TRIGGER_INIT
                {
                	mTRIGGER_INIT(); 

                }
                break;
            case 32 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:403: TRIGGER_CLEANUP
                {
                	mTRIGGER_CLEANUP(); 

                }
                break;
            case 33 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:419: TRIGGER_TIME
                {
                	mTRIGGER_TIME(); 

                }
                break;
            case 34 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:432: TRIGGER_PERIODIC
                {
                	mTRIGGER_PERIODIC(); 

                }
                break;
            case 35 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:449: TRIGGER_SCROLLING
                {
                	mTRIGGER_SCROLLING(); 

                }
                break;
            case 36 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:467: TRIGGER_ANIMATION_END
                {
                	mTRIGGER_ANIMATION_END(); 

                }
                break;
            case 37 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:489: TRIGGER_EVENT
                {
                	mTRIGGER_EVENT(); 

                }
                break;
            case 38 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:503: COLOR
                {
                	mCOLOR(); 

                }
                break;
            case 39 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:509: DIRECTION
                {
                	mDIRECTION(); 

                }
                break;
            case 40 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:519: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 41 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:526: POINT
                {
                	mPOINT(); 

                }
                break;
            case 42 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:532: RECTANGLE
                {
                	mRECTANGLE(); 

                }
                break;
            case 43 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:542: CLASS_IDENTIFIER
                {
                	mCLASS_IDENTIFIER(); 

                }
                break;
            case 44 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:559: INSTANCE_IDENTIFIER
                {
                	mINSTANCE_IDENTIFIER(); 

                }
                break;
            case 45 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:579: STRING
                {
                	mSTRING(); 

                }
                break;
            case 46 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:586: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 47 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:597: ML_COMMENT
                {
                	mML_COMMENT(); 

                }
                break;
            case 48 :
                // C:\\Kamaku\\svn\\gbe\\trunk\\src\\Gbe.Script\\Gbs.g:1:608: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;

        }

    }


    protected DFA1 dfa1;
    protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
	    this.dfa1 = new DFA1(this);
	    this.dfa16 = new DFA16(this);


	}

    const string DFA1_eotS =
        "\x0c\uffff";
    const string DFA1_eofS =
        "\x0c\uffff";
    const string DFA1_minS =
        "\x01\x23\x01\x6c\x07\uffff\x01\x61\x02\uffff";
    const string DFA1_maxS =
        "\x01\x79\x01\x6c\x07\uffff\x01\x75\x02\uffff";
    const string DFA1_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x06\x01\x07\x01\x08\x01"+
        "\x09\x01\uffff\x01\x01\x01\x05";
    const string DFA1_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x08\x3e\uffff\x01\x01\x04\uffff\x01\x04\x04\uffff\x01"+
            "\x07\x03\uffff\x01\x06\x01\uffff\x01\x03\x04\uffff\x01\x02\x01"+
            "\uffff\x01\x05",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x13\uffff\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "155:1: COLOR : ( 'black' | 'white' | 'red' | 'green' | 'blue' | 'yellow' | 'pink' | 'lightblue' | '#' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT );"; }
        }

    }

    const string DFA16_eotS =
        "\x07\uffff\x01\x1f\x04\x1e\x06\x1f\x02\uffff\x05\x1f\x01\uffff"+
        "\x02\x1f\x01\uffff\x01\x4a\x05\uffff\x01\x1f\x06\x1e\x09\x1f\x05"+
        "\uffff\x01\x4a\x07\uffff\x07\x1f\x01\x6d\x01\x1f\x02\uffff\x01\x4a"+
        "\x03\uffff\x01\x1f\x07\x1e\x01\x7b\x08\x1f\x05\uffff\x03\x1f\x01"+
        "\x19\x04\x1f\x01\uffff\x01\x1f\x01\x4a\x01\uffff\x01\u008e\x01\uffff"+
        "\x01\u0092\x07\x1e\x01\uffff\x03\x1f\x01\x19\x04\x1f\x02\uffff\x01"+
        "\x1f\x01\x19\x04\x1f\x02\x6d\x01\uffff\x01\u008e\x01\uffff\x01\u008e"+
        "\x01\uffff\x01\x1e\x01\u00a8\x01\u00a9\x03\x1e\x01\u00ad\x01\x1f"+
        "\x01\x19\x01\x1f\x01\u00b0\x01\u00b1\x02\x1f\x02\x19\x01\x6d\x02"+
        "\x1f\x01\u008e\x01\u00b6\x02\uffff\x01\u00b7\x01\u00b8\x01\u00b9"+
        "\x01\uffff\x02\x1f\x02\uffff\x02\x1f\x01\x19\x01\x1f\x04\uffff\x05"+
        "\x1f\x01\u00c4\x01\u00c5\x03\x1f\x02\uffff\x01\u00c9\x01\u00ca\x01"+
        "\x19\x02\uffff";
    const string DFA16_eofS =
        "\u00cb\uffff";
    const string DFA16_minS =
        "\x01\x09\x06\uffff\x01\x68\x01\x4e\x01\x4c\x01\x55\x01\x43\x01"+
        "\x70\x01\x61\x01\x69\x01\x6f\x01\x63\x01\x6e\x01\x30\x01\x61\x01"+
        "\x6c\x01\x68\x03\x65\x01\uffff\x01\x70\x01\x6f\x02\x2e\x04\uffff"+
        "\x01\x2a\x01\x69\x02\x45\x01\x41\x01\x4c\x01\x52\x01\x41\x01\x73"+
        "\x01\x6d\x01\x65\x01\x73\x01\x6e\x01\x6c\x01\x65\x01\x72\x01\x69"+
        "\x01\x65\x02\uffff\x01\x65\x01\uffff\x01\x30\x07\uffff\x01\x61\x01"+
        "\x69\x01\x64\x01\x67\x01\x6c\x01\x67\x01\x66\x01\x30\x01\x77\x01"+
        "\x30\x01\uffff\x01\x30\x01\x2b\x02\uffff\x01\x73\x01\x49\x01\x4d"+
        "\x01\x4e\x01\x59\x01\x4c\x01\x49\x01\x54\x01\x30\x02\x65\x01\x69"+
        "\x01\x6b\x01\x6f\x01\x65\x01\x6f\x01\x6d\x02\uffff\x01\x61\x02\uffff"+
        "\x01\x63\x01\x65\x01\x74\x01\x30\x01\x68\x01\x6c\x01\x68\x01\x74"+
        "\x01\uffff\x01\x6e\x01\x30\x01\x2e\x01\x2d\x02\x30\x01\x4e\x01\x59"+
        "\x01\x54\x02\x45\x01\x50\x01\x45\x01\uffff\x01\x41\x01\x6e\x01\x74"+
        "\x01\x30\x01\x72\x01\x64\x01\x6c\x01\x61\x02\uffff\x01\x6b\x01\x30"+
        "\x01\x65\x01\x74\x01\x6f\x01\x74\x02\x30\x01\uffff\x01\x2d\x01\uffff"+
        "\x01\x2d\x01\uffff\x01\x45\x02\x30\x01\x52\x02\x54\x01\x30\x01\x72"+
        "\x01\x30\x01\x69\x02\x30\x01\x6c\x01\x74\x03\x30\x01\x77\x01\x62"+
        "\x01\x2d\x01\x30\x02\uffff\x03\x30\x01\uffff\x01\x65\x01\x6f\x02"+
        "\uffff\x02\x69\x01\x30\x01\x6c\x04\uffff\x01\x61\x02\x6e\x01\x6f"+
        "\x01\x75\x02\x30\x01\x67\x01\x6e\x01\x65\x02\uffff\x03\x30\x02\uffff";
    const string DFA16_maxS =
        "\x01\x7d\x06\uffff\x01\x68\x01\x56\x01\x4c\x01\x55\x01\x54\x01"+
        "\x70\x01\x72\x02\x6f\x01\x70\x01\x6e\x01\x73\x01\x74\x01\x6c\x01"+
        "\x68\x01\x69\x01\x65\x01\x69\x01\uffff\x01\x70\x01\x6f\x01\x39\x01"+
        "\x3a\x04\uffff\x01\x2f\x01\x69\x01\x47\x01\x45\x01\x41\x01\x4c\x01"+
        "\x52\x01\x41\x01\x73\x01\x6d\x01\x65\x01\x73\x01\x6e\x01\x6c\x01"+
        "\x65\x01\x72\x01\x69\x01\x6c\x02\uffff\x01\x75\x01\uffff\x01\x3a"+
        "\x07\uffff\x01\x75\x01\x69\x01\x64\x01\x67\x01\x6c\x01\x67\x01\x66"+
        "\x01\x7a\x01\x77\x01\x39\x01\uffff\x01\x3a\x01\x39\x02\uffff\x01"+
        "\x73\x01\x49\x01\x4d\x01\x4e\x01\x59\x01\x4c\x01\x49\x01\x54\x01"+
        "\x7a\x02\x65\x01\x69\x01\x6b\x01\x6f\x01\x65\x01\x6f\x01\x6d\x02"+
        "\uffff\x01\x6f\x02\uffff\x01\x63\x01\x65\x01\x74\x01\x7a\x01\x68"+
        "\x01\x6c\x01\x68\x01\x74\x01\uffff\x01\x6e\x01\x3a\x03\x39\x01\x7a"+
        "\x01\x4e\x01\x59\x01\x54\x02\x45\x01\x50\x01\x45\x01\uffff\x01\x41"+
        "\x01\x6e\x01\x74\x01\x7a\x01\x72\x01\x64\x01\x6c\x01\x61\x02\uffff"+
        "\x01\x6b\x01\x7a\x01\x65\x01\x74\x01\x6f\x01\x74\x02\x7a\x01\uffff"+
        "\x01\x39\x01\uffff\x01\x39\x01\uffff\x01\x45\x02\x7a\x01\x52\x02"+
        "\x54\x01\x7a\x01\x72\x01\x7a\x01\x69\x02\x7a\x01\x6c\x01\x74\x03"+
        "\x7a\x01\x77\x01\x62\x01\x39\x01\x7a\x02\uffff\x03\x7a\x01\uffff"+
        "\x01\x65\x01\x6f\x02\uffff\x02\x69\x01\x7a\x01\x6c\x04\uffff\x01"+
        "\x61\x02\x6e\x01\x6f\x01\x75\x02\x7a\x01\x67\x01\x6e\x01\x65\x02"+
        "\uffff\x03\x7a\x02\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x12"+
        "\uffff\x01\x26\x04\uffff\x01\x2b\x01\x2c\x01\x2d\x01\x2e\x12\uffff"+
        "\x01\x17\x01\x18\x01\uffff\x01\x1e\x01\uffff\x01\x1f\x01\x20\x01"+
        "\x21\x01\x22\x01\x23\x01\x24\x01\x25\x0a\uffff\x01\x28\x02\uffff"+
        "\x01\x2f\x01\x30\x11\uffff\x01\x16\x01\x1c\x01\uffff\x01\x1b\x01"+
        "\x1d\x08\uffff\x01\x27\x0d\uffff\x01\x0f\x08\uffff\x01\x19\x01\x1a"+
        "\x08\uffff\x01\x29\x01\uffff\x01\x2a\x01\uffff\x01\x07\x15\uffff"+
        "\x01\x0b\x01\x0e\x03\uffff\x01\x0d\x02\uffff\x01\x12\x01\x13\x04"+
        "\uffff\x01\x08\x01\x09\x01\x0a\x01\x0c\x0a\uffff\x01\x10\x01\x11"+
        "\x03\uffff\x01\x15\x01\x14";
    const string DFA16_specialS =
        "\u00cb\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x02\x21\x01\uffff\x02\x21\x12\uffff\x01\x21\x01\uffff\x01"+
            "\x20\x01\x19\x04\uffff\x01\x05\x01\x06\x01\uffff\x01\x1c\x01"+
            "\x02\x01\x1c\x01\x12\x01\x22\x0a\x1d\x03\uffff\x01\x01\x02\uffff"+
            "\x01\x13\x01\x1e\x01\x0a\x02\x1e\x01\x08\x0a\x1e\x01\x09\x02"+
            "\x1e\x01\x0b\x07\x1e\x06\uffff\x01\x11\x01\x14\x01\x0f\x01\x1b"+
            "\x01\x1f\x01\x0c\x01\x0d\x04\x1f\x01\x18\x03\x1f\x01\x0e\x01"+
            "\x1f\x01\x16\x01\x10\x01\x07\x01\x1a\x01\x1f\x01\x15\x01\x1f"+
            "\x01\x17\x01\x1f\x01\x03\x01\uffff\x01\x04",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x23",
            "\x01\x24\x07\uffff\x01\x25",
            "\x01\x26",
            "\x01\x27",
            "\x01\x28\x10\uffff\x01\x29",
            "\x01\x2a",
            "\x01\x2b\x10\uffff\x01\x2c",
            "\x01\x2e\x05\uffff\x01\x2d",
            "\x01\x2f",
            "\x01\x31\x0c\uffff\x01\x30",
            "\x01\x32",
            "\x0a\x38\x2a\uffff\x01\x35\x01\uffff\x01\x34\x09\uffff\x01"+
            "\x33\x01\uffff\x01\x37\x01\x36",
            "\x01\x3e\x01\uffff\x01\x3a\x01\uffff\x01\x3f\x03\uffff\x01"+
            "\x39\x06\uffff\x01\x3c\x02\uffff\x01\x3d\x01\x3b",
            "\x01\x40",
            "\x01\x41",
            "\x01\x42\x03\uffff\x01\x43",
            "\x01\x44",
            "\x01\x46\x03\uffff\x01\x45",
            "",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49\x01\uffff\x0a\x1d",
            "\x01\x4b\x01\uffff\x0a\x1d\x01\x4c",
            "",
            "",
            "",
            "",
            "\x01\x4d\x04\uffff\x01\x4e",
            "\x01\x4f",
            "\x01\x51\x01\uffff\x01\x50",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60\x06\uffff\x01\x61",
            "",
            "",
            "\x01\x64\x0e\uffff\x01\x62\x01\x63",
            "",
            "\x0a\x38\x01\x4c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x65\x13\uffff\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\x6e",
            "\x0a\x38",
            "",
            "\x0a\x6f\x01\x4c",
            "\x01\x70\x01\uffff\x01\x70\x01\x72\x01\uffff\x0a\x71",
            "",
            "",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "",
            "",
            "\x01\u0084\x0d\uffff\x01\u0085",
            "",
            "",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "",
            "\x01\u008d",
            "\x0a\x6f\x01\x4c",
            "\x01\x72\x01\uffff\x0a\x71",
            "\x01\u0090\x01\u008f\x01\uffff\x0a\x71",
            "\x0a\u0091",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "",
            "\x01\u009a",
            "\x01\u009b",
            "\x01\u009c",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u009d",
            "\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "",
            "",
            "\x01\u00a1",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00a2",
            "\x01\u00a3",
            "\x01\u00a4",
            "\x01\u00a5",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "",
            "\x01\u0090\x02\uffff\x0a\u00a6",
            "",
            "\x01\u0090\x02\uffff\x0a\u0091",
            "",
            "\x01\u00a7",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x01\u00ac",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00ae",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00af",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00b4",
            "\x01\u00b5",
            "\x01\u0090\x02\uffff\x0a\u00a6",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x01\u00ba",
            "\x01\u00bb",
            "",
            "",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00be",
            "",
            "",
            "",
            "",
            "\x01\u00bf",
            "\x01\u00c0",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x01\u00c3",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x01\u00c6",
            "\x01\u00c7",
            "\x01\u00c8",
            "",
            "",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "\x0a\x1f\x07\uffff\x1a\x1f\x06\uffff\x1a\x1f",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | THIS | CLASSDEF_ENGINE | CLASSDEF_PLAYER | CLASSDEF_BULLET | CLASSDEF_ENEMY | CLASSDEF_SCRIPT | CLASSDEF_STATE | CLASSDEF_EVENT | PARAM_FPS | PARAM_GAMEAREA | PARAM_POSITION | PARAM_COLOR | PARAM_SPEED | PARAM_ANIMATION | PARAM_SCROLLING | ACTION_PERIODIC | ACTION_FIRE_AT_PLAYER | ACTION_DIE | ACTION_START | ACTION_STOP | ACTION_SUMMON | ACTION_PLAY_ANIMATION | ACTION_SET | ACTION_RAISE | TRIGGER_INIT | TRIGGER_CLEANUP | TRIGGER_TIME | TRIGGER_PERIODIC | TRIGGER_SCROLLING | TRIGGER_ANIMATION_END | TRIGGER_EVENT | COLOR | DIRECTION | NUMBER | POINT | RECTANGLE | CLASS_IDENTIFIER | INSTANCE_IDENTIFIER | STRING | WHITESPACE | ML_COMMENT | SL_COMMENT );"; }
        }

    }

 
    
}
}