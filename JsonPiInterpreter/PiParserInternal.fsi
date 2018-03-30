// Signature file for parser generated by fsyacc
module internal PiParserInternal
type token = 
  | EOF
  | JSON_FLOAT of (string)
  | JSON_INT of (string)
  | JSON_STRING of (string)
  | JSON_NULL of (string)
  | JSON_BOOL of (string)
  | ID of (string)
  | NEW
  | LET
  | MODULE
  | USING
  | CHOOSE
  | WHEN
  | THEN
  | DEFAULT
  | END
  | CONTINUE
  | IN
  | SYM_DOLLAR
  | SYM_LPAREN
  | SYM_RPAREN
  | SYM_EQUALS
  | SYM_BANG
  | SYM_BAR
  | SYM_COMMA
  | SYM_PERIOD
  | SYM_LANGLE
  | SYM_RANGLE
  | SYM_LBRACKET
  | SYM_RBRACKET
  | SYM_LCURLY
  | SYM_RCURLY
  | SYM_SEMICOLON
  | SYM_COLON
type tokenId = 
    | TOKEN_EOF
    | TOKEN_JSON_FLOAT
    | TOKEN_JSON_INT
    | TOKEN_JSON_STRING
    | TOKEN_JSON_NULL
    | TOKEN_JSON_BOOL
    | TOKEN_ID
    | TOKEN_NEW
    | TOKEN_LET
    | TOKEN_MODULE
    | TOKEN_USING
    | TOKEN_CHOOSE
    | TOKEN_WHEN
    | TOKEN_THEN
    | TOKEN_DEFAULT
    | TOKEN_END
    | TOKEN_CONTINUE
    | TOKEN_IN
    | TOKEN_SYM_DOLLAR
    | TOKEN_SYM_LPAREN
    | TOKEN_SYM_RPAREN
    | TOKEN_SYM_EQUALS
    | TOKEN_SYM_BANG
    | TOKEN_SYM_BAR
    | TOKEN_SYM_COMMA
    | TOKEN_SYM_PERIOD
    | TOKEN_SYM_LANGLE
    | TOKEN_SYM_RANGLE
    | TOKEN_SYM_LBRACKET
    | TOKEN_SYM_RBRACKET
    | TOKEN_SYM_LCURLY
    | TOKEN_SYM_RCURLY
    | TOKEN_SYM_SEMICOLON
    | TOKEN_SYM_COLON
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_Assembly
    | NONTERM_Modules
    | NONTERM_Module
    | NONTERM_Process
    | NONTERM_ModuleRef
    | NONTERM_ModuleInAssembly
    | NONTERM_ProcessDefinition
    | NONTERM_ProcessReplication
    | NONTERM_ProcessRestriction
    | NONTERM_RestrictionName
    | NONTERM_RestrictionType
    | NONTERM_RestrictionInitialization
    | NONTERM_ProcessComposition
    | NONTERM_ProcessReference
    | NONTERM_ProcessExtensionContinue
    | NONTERM_ProcessSummation
    | NONTERM_Summation
    | NONTERM_SummationSum
    | NONTERM_SummationChoiceList
    | NONTERM_SummationChoice
    | NONTERM_ChooseDefault
    | NONTERM_SummationPrefix
    | NONTERM_SummationInaction
    | NONTERM_Prefix
    | NONTERM_PrefixOutput
    | NONTERM_PrefixInput
    | NONTERM_PrefixMatch
    | NONTERM_ParamList
    | NONTERM_TypedParamList
    | NONTERM_Param
    | NONTERM_TypedParam
    | NONTERM_DottedId
    | NONTERM_JsonValue
    | NONTERM_JsonString
    | NONTERM_JsonNumber
    | NONTERM_JsonObject
    | NONTERM_JsonMembers
    | NONTERM_JsonPair
    | NONTERM_JsonArray
    | NONTERM_JsonElements
    | NONTERM_JsonBool
    | NONTERM_JsonNull
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( PiJsonObject ) 
