grammar LabCalculator;

/*
 * Parser Rules
 */

compileUnit : expression EOF;



expression :
	operatorToken=(MMAX | MMIN) LPAREN expression RPAREN #ParenthesizedExpr
	|LPAREN expression RPAREN #ParenthesizedExpr
	|expression EXPONENT expression #ExponentialExpr
    | expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
	| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr 
	| expression operatorToken=(DIV | MOD) expression #ModDivExpr
	| SUBSTRACT expression #UnarExpr
	| tokenOperator=(NUMBER | COMMA) expression #BigExpr
	| NUMBER #NumberExpr 
	| tokenOperator=(MAX | MIN) LPAREN expression COMMA expression RPAREN #MaxMinExpr
	| IDENTIFIER #IdentifierExpr
	; 


	

/*
 * Lexer Rules
 */

NUMBER : INT ('.' INT)?; 
IDENTIFIER : [a-zA-Z]+[1-9][0-9]+;

INT : ('0'..'9')+;

EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';
COMMA : ',';
DIV : 'div';
MOD : 'mod';
MAX : 'max';
MIN : 'min';

WS : [ \t\r\n] -> channel(HIDDEN);