�

ZC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\BankServices\CentralBankService.cs
	namespace 	

 
{ 
public 
class	 
CentralBankService !
{ 
public 

decimal 
ConvertRate 
( 
CurrencyRate +
currencyRate, 8
)8 9
{ 
return 
currencyRate
. 
Price 
/  !
(" #
decimal# *
)* +
$num+ /
;/ 0
} 
}		 
public 
class	 %
CentralBankServiceAdapter (
:) *
IBankService+ 7
{ 
public

decimal
ConvertRate
(
CurrencyRate
currencyRate
)
{ 
CentralBankService 
centralBankService +
=+ ,
new, /
CentralBankService0 B
(B C
)C D
;D E
return 
centralBankService
.  
ConvertRate  +
(+ ,
currencyRate, 8
)8 9
;9 :
} 
} 
} �
WC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\BankServices\FakeBankService.cs
	namespace 	

 
{ 
public 
class	 
FakeBankService 
:  
IBankService! -
{ 
public 

decimal 
ConvertRate 
( 
CurrencyRate +
currencyRate, 8
)8 9
{ 
return 
currencyRate
. 
Price 
/  !
(" #
decimal# *
)* +
$num+ /
;/ 0
} 
}		 
}

 �
PC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Business\CurrencyRate.cs
	namespace 	

 
{ 
public 
class	 
CurrencyRate 
: 
IEntity #
{ 
public 

decimal 
Price 
{ 
get 
; 
set  #
;# $
}% &
public 

int 
Currency 
{ 
get 
; 
set "
;" #
}$ %
} 
} �
LC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Entities\Customer.cs
	namespace 	

 
{ 
public 
class	 
Customer 
: 
IEntity !
,! "
IPerson# *
{ 
public 

int 
Id 
{ 
get 
; 
set 
; 
} 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
public		 

decimal		 
Price		 
(		 
Product		  
product		! (
)		( )
{

 
var 	
result
 
= 
product 
. 
ProductPrice '
;' (
return 
result
; 
}
} 
} �
TC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\BankServices\IBankService.cs
	namespace 	

 
{ 
public 
	interface	 
IBankService 
{ 
decimal 
ConvertRate 
( 
CurrencyRate $
currencyRate% 1
)1 2
;2 3
} 
} �
MC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Interfaces\IEntity.cs
	namespace 	

 
{ 
public 
	interface	 
IEntity 
{ 
} 
} �
MC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Interfaces\IPerson.cs
	namespace 	

 
{ 
public 
	interface	 
IPerson 
{ 
int 
Id 

{ 
get
; 
set 
; 
} 
string 

Name 
{ 
get 
; 
set 
; 
} 
decimal 
Price 
( 
Product 
product !
)! "
;" #
} 
}		 �
UC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Interfaces\IProductService.cs
	namespace 	

 
{ 
public 
	interface	 
IProductService "
{ 
void 
Sell	 
(
Product 
product 
, 
IPerson %
person& ,
), -
;- .
} 
} �	
UC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\BankServices\IsBankService.cs
	namespace 	

 
{ 
public 
class	 

{ 
public 

decimal 
ConvertRate 
( 
CurrencyRate +
currencyRate, 8
)8 9
{ 
return 
currencyRate
. 
Price 
/  !
(" #
decimal# *
)* +
$num+ /
;/ 0
} 
}		 
public

 
class

	  
IsBankServiceAdapter

 #
:

$ %
IBankService

& 2
{ 
public 

decimal 
ConvertRate 
( 
CurrencyRate +
currencyRate, 8
)8 9
{

centralBankService &
=' (
new) ,

(: ;
); <
;< =
return 
centralBankService
.  
ConvertRate  +
(+ ,
currencyRate, 8
)8 9
;9 :
} 
} 
} �
KC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Entities\Officer.cs
	namespace 	

 
{ 
public 
class	 
Officer 
: 
IEntity  
,  !
IPerson" )
{ 
public 

int 
Id 
{ 
get 
; 
set 
; 
} 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
public		 

decimal		 
Price		 
(		 
Product		  
product		! (
)		( )
{

 
var 	
result
 
= 
product 
. 
ProductPrice '
*( )
(* +
decimal+ 2
)2 3
$num3 7
;7 8
return 
result
; 
}
} 
} �
KC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Entities\Product.cs
	namespace 	

 
{ 
public 
class	 
Product 
: 
IEntity  
{ 
public 

int 
	ProductId 
{ 
get 
; 
set  #
;# $
}% &
public 

string 
ProductName 
{ 
get  #
;# $
set% (
;( )
}* +
public 

decimal 
ProductPrice 
{  !
get" %
;% &
set' *
;* +
}, -
} 
}		 �
RC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Business\ProductManager.cs
	namespace 	

 
{ 
public 
class	 
ProductManager 
: 
IProductService  /
{ 
private 
readonly 
IBankService !
_bankService" .
;. /
public		 

ProductManager		 
(		 
IBankService		 &
bankService		' 2
)		2 3
{

 
_bankService 
= 
bankService  
;  !
} 
public 

void 
Sell 
( 
Product 
product $
,$ %
IPerson& -
person. 4
)4 5
{ 
var 	
price
 
= 
person 
. 
Price 
( 
product &
)& '
;' (
var 	

 
= 
_bankService &
.& '
ConvertRate' 2
(2 3
new3 6
CurrencyRate7 C
{D E
CurrencyF N
=O P
$numQ R
,R S
PriceT Y
=Z [
price\ a
}b c
)c d
;d e
Console 
.
	WriteLine 
( 
$str 9
+: ;
price< A
.A B
ToStringB J
(J K
$strK Q
)Q R
)R S
;S T
Console 
.
	WriteLine 
( 
$str *
++ ,

.: ;
ToString; C
(C D
$strD J
)J K
)K L
;L M
} 
} 
} �
BC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Program.cs
	namespace 	

 
{ 
class 
Program 
{ 
	protected 
Program 
( 
) 
{ 
}

 
static 

void 
Main 
( 
string 
[ 
] 
args "
)" #
{ 
IProductService
productService
=
new
ProductManager
(
new
IsBankServiceAdapter
(
)
)
;
productService 
. 
Sell 
( 
new 
Product 
{ 
	ProductId 
=  !
$num" #
,# $
ProductName% 0
=1 2
$str3 ;
,; <
ProductPrice= I
=J K
$numL P
}Q R
,R S
new 
Student 
{ 
Id 
= 
$num 
, 
Name "
=# $
$str% ,
}- .
) 	
;	 

Console 
.
ReadLine 
( 
) 
; 
} 
} 
} �
RC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str (
)( )
]) *
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str *
)* +
]+ ,
[
assembly
:

AssemblyCopyright
(
$str
)
]
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *�
KC:\Users\kerem\source\repos\CleanCodeDemo\CleanCodeDemo\Entities\Student.cs
	namespace 	

 
{ 
public 
class	 
Student 
: 
IEntity  
,  !
IPerson" )
{ 
public 

int 
Id 
{ 
get 
; 
set 
; 
} 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
public		 

decimal		 
Price		 
(		 
Product		  
product		! (
)		( )
{

 
var 	
result
 
= 
product 
. 
ProductPrice '
*( )
(* +
decimal+ 2
)2 3
$num3 7
;7 8
return 
result
; 
}
} 
} 