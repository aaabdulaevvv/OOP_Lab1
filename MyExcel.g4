grammar MyExcel;

/*
* Parser Rules
*/
compileUnit : expression EOF;
expression :
LPAREN expression RPAREN #ParenthesizedExpr
| expression EXPONENT expression #ExponentialExpr
| expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
| operatorToken=MIN LPAREN expression ',' expression RPAREN #MinExpr
| operatorToken=MAX LPAREN expression ',' expression RPAREN #MaxExpr
| operatorToken=INC LPAREN expression RPAREN #IncExpr
| operatorToken=DEC LPAREN expression RPAREN #DecExpr
| NUMBER #NumberExpr
| IDENTIFIER #IdentifierExpr
;
/*
* Lexer Rules
*/
NUMBER : INT ('.' INT)?;
IDENTIFIER : [A-Z]+[1-9][0-9]*;
INT : ('0'..'9')+;
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';
MAX: 'max';
MIN: 'min';
INC: 'inc';
DEC: 'dec';
WS : [ \t\r\n] -> channel(HIDDEN);