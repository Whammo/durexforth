variable end
: <# here end ! ;
: #> 2drop here end @ over - ;
: ins \ reserve space for char at start
here dup 1+ end @ here - cmove> 
1 end +! ;
: hold ins here c! ;
: sign 0< if [char] - hold then ;
: # base @ um/mod swap #pet hold 0 ;