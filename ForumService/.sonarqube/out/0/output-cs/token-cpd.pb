“
‚C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\ResponseRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
{ 
public 

class 
ResponseRepository #
:$ %
BaseRepository& 4
<4 5
ResponseEntity5 C
>C D
,D E
IResponseRepositoryF Y
{ 
private		 
readonly		 
ForumContext		 %
_context		& .
;		. /
public

 
ResponseRepository

 !
(

! "
ForumContext

" .
context

/ 6
)

6 7
:

8 9
base

: >
(

> ?
context

? F
)

F G
{ 	
_context 
= 
context 
; 
} 	
public 
async 
Task 
< 
List 
< 
ResponseEntity -
>- .
>. /
GetByPostId0 ;
(; <
int< ?
PostId@ F
)F G
{ 	
List 
< 
ResponseEntity 
>  
	responses! *
=+ ,
await- 2
_context3 ;
.; <
Set< ?
<? @
ResponseEntity@ N
>N O
(O P
)P Q
. 
Where 
( 
e 
=> 
e 
. 
PostId $
==% '
PostId( .
). /
. 
ToListAsync 
( 
) 
; 
return 
	responses 
; 
} 	
} 
} î
~C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\PostRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
{ 
public 

class 
PostRepository 
:  !
BaseRepository" 0
<0 1

PostEntity1 ;
>; <
,< =
IPostRepository> M
{ 
private		 
readonly		 
ForumContext		 %
_context		& .
;		. /
public

 
PostRepository

 
(

 
ForumContext

 *
context

+ 2
)

2 3
:

4 5
base

6 :
(

: ;
context

; B
)

B C
{ 	
_context 
= 
context 
; 
} 	
public 
async 
Task 
< 
List 
< 

PostEntity )
>) *
>* +
GetByForumId, 8
(8 9
int9 <
ForumId= D
)D E
{ 	
List 
< 

PostEntity 
> 
posts "
=# $
await% *
_context+ 3
.3 4
Set4 7
<7 8

PostEntity8 B
>B C
(C D
)D E
. 
Where 
( 
e 
=> 
e 
. 
ForumId %
==& (
ForumId) 0
)0 1
. 
ToListAsync 
( 
) 
; 
return 
posts 
; 
} 	
} 
} º
~C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\LikeRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
{ 
public 

class 
LikeRepository 
:  !
BaseRepository" 0
<0 1

LikeEntity1 ;
>; <
,< =
ILikeRepository> M
{ 
private		 
readonly		 
ForumContext		 %
_context		& .
;		. /
public

 
LikeRepository

 
(

 
ForumContext

 *
context

+ 2
)

2 3
:

4 5
base

6 :
(

: ;
context

; B
)

B C
{ 	
_context 
= 
context 
; 
} 	
public 
Task 
< 
List 
< 

LikeEntity #
># $
>$ %
GetAllLikesPost& 5
(5 6
int6 9
postId: @
)@ A
{ 	
return 
_context 
. 
Likes !
. 
Where 
( 
l 
=> 
l 
. 
PostId $
==% '
postId( .
). /
. 
ToListAsync 
( 
) 
; 
} 	
public 
Task 
< 
List 
< 

LikeEntity #
># $
>$ %
GetAllLikesResponse& 9
(9 :
int: =

responseId> H
)H I
{ 	
return 
_context 
. 
Likes !
. 
Where 
( 
l 
=> 
l 
. 

ResponseId (
==) +

responseId, 6
)6 7
. 
ToListAsync 
( 
) 
; 
} 	
public 
Task 
< 
List 
< 

LikeEntity #
># $
>$ %
GetAllLikesUser& 5
(5 6
int6 9
userId: @
)@ A
{ 	
return 
_context 
. 
Likes !
.   
Where   
(   
l   
=>   
l   
.   
UserId   $
==  % '
userId  ( .
)  . /
.!! 
ToListAsync!! 
(!! 
)!! 
;!! 
}"" 	
}## 
}$$ ³	
ŠC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\Interfaces\ILikeRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
.+ ,

Interfaces, 6
{ 
public 

	interface 
ILikeRepository $
:% &
IBaseRepository' 6
<6 7

LikeEntity7 A
>A B
{ 
Task 
< 
List 
< 

LikeEntity 
> 
> 
GetAllLikesPost .
(. /
int/ 2
postId3 9
)9 :
;: ;
Task		 
<		 
List		 
<		 

LikeEntity		 
>		 
>		 
GetAllLikesResponse		 2
(		2 3
int		3 6

responseId		7 A
)		A B
;		B C
Task

 
<

 
List

 
<

 

LikeEntity

 
>

 
>

 
GetAllLikesUser

 .
(

. /
int

/ 2
userId

3 9
)

9 :
;

: ;
} 
} ã
ŠC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\Interfaces\IBaseRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Services '
.' (

Interfaces( 2
{ 
public 

	interface 
IBaseRepository $
<$ %
TEntity% ,
>, -
where. 3
TEntity4 ;
:< =
class> C
{ 
Task 
< 
TEntity 
> 
GetByIdAsync "
(" #
int# &
id' )
)) *
;* +
Task 
< 
TEntity 
> 
AddAsync 
( 
TEntity &
entity' -
)- .
;. /
void 
Update 
( 
TEntity 
entity "
)" #
;# $
void 
Remove 
( 
TEntity 
entity "
)" #
;# $
}		 
}

 ×
ŠC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\Interfaces\IPostRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Services '
.' (

Interfaces( 2
{ 
public 

	interface 
IPostRepository $
:% &
IBaseRepository' 6
<6 7

PostEntity7 A
>A B
{ 
Task 
< 
List 
< 

PostEntity 
> 
> 
GetByForumId +
(+ ,
int, /
ForumId0 7
)7 8
;8 9
} 
}		 å
ŽC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\Interfaces\IResponseRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Services '
.' (

Interfaces( 2
{ 
public 

	interface 
IResponseRepository (
:) *
IBaseRepository+ :
<: ;
ResponseEntity; I
>I J
{ 
Task 
< 
List 
< 
ResponseEntity  
>  !
>! "
GetByPostId# .
(. /
int/ 2
PostId3 9
)9 :
;: ;
} 
}		 ß
‹C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\Interfaces\IForumRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Services '
.' (

Interfaces( 2
{ 
public 

	interface 
IForumRepository %
:& '
IBaseRepository( 7
<7 8
ForumEntity8 C
>C D
{ 
Task 
< 
List 
< 
ForumEntity 
> 
> 
GetAllForums  ,
(, -
string- 3
audience4 <
)< =
;= >
} 
}		 Æ
C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\ForumRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
{ 
public 

class 
ForumRepository  
:! "
BaseRepository# 1
<1 2
ForumEntity2 =
>= >
,> ?
IForumRepository@ P
{ 
public		 
ForumRepository		 
(		 
ForumContext		 +
context		, 3
)		3 4
:		5 6
base		7 ;
(		; <
context		< C
)		C D
{

 	
} 	
public 
Task 
< 
List 
< 
ForumEntity $
>$ %
>% &
GetAllForums' 3
(3 4
string4 :
audience; C
)C D
{ 	
return 
_context 
. 
Forums "
. 
Where 
( 
f 
=> 
( 
audience %
==& (
null) -
&&. 0
f1 2
.2 3
Audience3 ;
==< >
$str? E
)E F
||G I
( 
audience %
==& (
$str) :
&&; =
(> ?
f? @
.@ A
AudienceA I
==J L
$strM ^
||_ a
fb c
.c d
Audienced l
==m o
$strp u
)u v
)v w
||x z
( 
audience %
==& (
$str) 1
&&2 4
(5 6
f6 7
.7 8
Audience8 @
==A C
$strD M
||N P
fQ R
.R S
AudienceS [
==\ ^
$str_ d
)d e
)e f
)f g
. 
ToListAsync 
( 
) 
; 
} 	
} 
} ƒ
~C:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Repositories\BaseRepository.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Repositories +
{ 
public 

class 
BaseRepository 
<  
TEntity  '
>' (
:) *
IBaseRepository+ :
<: ;
TEntity; B
>B C
whereD I
TEntityJ Q
:R S
classT Y
{

 
	protected 
readonly 
ForumContext '
_context( 0
;0 1
public 
BaseRepository 
( 
ForumContext *
context+ 2
)2 3
{ 	
_context 
= 
context 
; 
} 	
public 
async 
Task 
< 
TEntity !
>! "
GetByIdAsync# /
(/ 0
int0 3
id4 6
)6 7
{ 	
return 
await 
_context !
.! "
Set" %
<% &
TEntity& -
>- .
(. /
)/ 0
.0 1
	FindAsync1 :
(: ;
id; =
)= >
;> ?
} 	
public 
async 
Task 
< 
TEntity !
>! "
AddAsync# +
(+ ,
TEntity, 3
entity4 :
): ;
{ 	
await 
_context 
. 
Set 
< 
TEntity &
>& '
(' (
)( )
.) *
AddAsync* 2
(2 3
entity3 9
)9 :
;: ;
await 
_context 
. 
SaveChangesAsync +
(+ ,
), -
;- .
return 
entity 
; 
} 	
public 
void 
Update 
( 
TEntity "
entity# )
)) *
{ 	
_context   
.   
Entry   
(   
entity   !
)  ! "
.  " #
State  # (
=  ) *
EntityState  + 6
.  6 7
Modified  7 ?
;  ? @
_context!! 
.!! 
SaveChanges!!  
(!!  !
)!!! "
;!!" #
}"" 	
public$$ 
void$$ 
Remove$$ 
($$ 
TEntity$$ "
entity$$# )
)$$) *
{%% 	
_context&& 
.&& 
Set&& 
<&& 
TEntity&&  
>&&  !
(&&! "
)&&" #
.&&# $
Remove&&$ *
(&&* +
entity&&+ 1
)&&1 2
;&&2 3
_context'' 
.'' 
SaveChanges''  
(''  !
)''! "
;''" #
}(( 	
})) 
}++ Æ
jC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddDbContext 
< 
ForumContext *
>* +
(+ ,
options, 3
=>4 6
{		 
options

 
.

 
	UseNpgsql

 
(

 
builder

 
.

 
Configuration

 +
.

+ ,
GetConnectionString

, ?
(

? @
$str

@ V
)

V W
)

W X
;

X Y
} 
) 
; 
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder 
. 
Services 
. 
AddSwaggerGen 
( 
)  
;  !
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
if 
( 
app 
. 
Environment 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
) 
; 
} 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
Run 
( 
) 	
;	 
Èl
ŠC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Migrations\20240522085452_first-version.cs
	namespace 	 
ForumRepositoryLayer
 
. 

Migrations )
{ 
public

 

partial

 
class

 
firstversion

 %
:

& '
	Migration

( 1
{ 
	protected 
override 
void 
Up  "
(" #
MigrationBuilder# 3
migrationBuilder4 D
)D E
{ 	
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str 
, 
columns 
: 
table 
=> !
new" %
{ 
Id 
= 
table 
. 
Column %
<% &
int& )
>) *
(* +
type+ /
:/ 0
$str1 :
,: ;
nullable< D
:D E
falseF K
)K L
. 

Annotation #
(# $
$str$ D
,D E)
NpgsqlValueGenerationStrategyF c
.c d#
IdentityByDefaultColumnd {
){ |
,| }
CategoryName  
=! "
table# (
.( )
Column) /
</ 0
string0 6
>6 7
(7 8
type8 <
:< =
$str> D
,D E
nullableF N
:N O
falseP U
)U V
,V W
Description 
=  !
table" '
.' (
Column( .
<. /
string/ 5
>5 6
(6 7
type7 ;
:; <
$str= C
,C D
nullableE M
:M N
falseO T
)T U
,U V
Audience 
= 
table $
.$ %
Column% +
<+ ,
int, /
>/ 0
(0 1
type1 5
:5 6
$str7 @
,@ A
nullableB J
:J K
falseL Q
)Q R
} 
, 
constraints 
: 
table "
=># %
{ 
table 
. 

PrimaryKey $
($ %
$str% 0
,0 1
x2 3
=>4 6
x7 8
.8 9
Id9 ;
); <
;< =
} 
) 
; 
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str 
, 
columns   
:   
table   
=>   !
new  " %
{!! 
Id"" 
="" 
table"" 
."" 
Column"" %
<""% &
int""& )
>"") *
(""* +
type""+ /
:""/ 0
$str""1 :
,"": ;
nullable""< D
:""D E
false""F K
)""K L
.## 

Annotation## #
(### $
$str##$ D
,##D E)
NpgsqlValueGenerationStrategy##F c
.##c d#
IdentityByDefaultColumn##d {
)##{ |
,##| }
Title$$ 
=$$ 
table$$ !
.$$! "
Column$$" (
<$$( )
string$$) /
>$$/ 0
($$0 1
type$$1 5
:$$5 6
$str$$7 =
,$$= >
nullable$$? G
:$$G H
false$$I N
)$$N O
,$$O P
Content%% 
=%% 
table%% #
.%%# $
Column%%$ *
<%%* +
string%%+ 1
>%%1 2
(%%2 3
type%%3 7
:%%7 8
$str%%9 ?
,%%? @
nullable%%A I
:%%I J
false%%K P
)%%P Q
,%%Q R
AuthorId&& 
=&& 
table&& $
.&&$ %
Column&&% +
<&&+ ,
int&&, /
>&&/ 0
(&&0 1
type&&1 5
:&&5 6
$str&&7 @
,&&@ A
nullable&&B J
:&&J K
false&&L Q
)&&Q R
,&&R S
Privacy'' 
='' 
table'' #
.''# $
Column''$ *
<''* +
int''+ .
>''. /
(''/ 0
type''0 4
:''4 5
$str''6 ?
,''? @
nullable''A I
:''I J
false''K P
)''P Q
,''Q R
DateTime(( 
=(( 
table(( $
.(($ %
Column((% +
<((+ ,
DateTime((, 4
>((4 5
(((5 6
type((6 :
:((: ;
$str((< V
,((V W
nullable((X `
:((` a
false((b g
)((g h
,((h i
Likes)) 
=)) 
table)) !
.))! "
Column))" (
<))( )
int))) ,
>)), -
())- .
type)). 2
:))2 3
$str))4 =
,))= >
nullable))? G
:))G H
false))I N
)))N O
,))O P
url** 
=** 
table** 
.**  
Column**  &
<**& '
string**' -
>**- .
(**. /
type**/ 3
:**3 4
$str**5 ;
,**; <
nullable**= E
:**E F
false**G L
)**L M
,**M N
PostId++ 
=++ 
table++ "
.++" #
Column++# )
<++) *
int++* -
>++- .
(++. /
type++/ 3
:++3 4
$str++5 >
,++> ?
nullable++@ H
:++H I
false++J O
)++O P
,++P Q
ForumEntityId,, !
=,," #
table,,$ )
.,,) *
Column,,* 0
<,,0 1
int,,1 4
>,,4 5
(,,5 6
type,,6 :
:,,: ;
$str,,< E
,,,E F
nullable,,G O
:,,O P
true,,Q U
),,U V
}-- 
,-- 
constraints.. 
:.. 
table.. "
=>..# %
{// 
table00 
.00 

PrimaryKey00 $
(00$ %
$str00% /
,00/ 0
x001 2
=>003 5
x006 7
.007 8
Id008 :
)00: ;
;00; <
table11 
.11 

ForeignKey11 $
(11$ %
name22 
:22 
$str22 =
,22= >
column33 
:33 
x33  !
=>33" $
x33% &
.33& '
ForumEntityId33' 4
,334 5
principalTable44 &
:44& '
$str44( 0
,440 1
principalColumn55 '
:55' (
$str55) -
)55- .
;55. /
table66 
.66 

ForeignKey66 $
(66$ %
name77 
:77 
$str77 5
,775 6
column88 
:88 
x88  !
=>88" $
x88% &
.88& '
PostId88' -
,88- .
principalTable99 &
:99& '
$str99( /
,99/ 0
principalColumn:: '
:::' (
$str::) -
,::- .
onDelete;;  
:;;  !
ReferentialAction;;" 3
.;;3 4
Cascade;;4 ;
);;; <
;;;< =
}<< 
)<< 
;<< 
migrationBuilder>> 
.>> 
CreateTable>> (
(>>( )
name?? 
:?? 
$str?? !
,??! "
columns@@ 
:@@ 
table@@ 
=>@@ !
new@@" %
{AA 
IdBB 
=BB 
tableBB 
.BB 
ColumnBB %
<BB% &
stringBB& ,
>BB, -
(BB- .
typeBB. 2
:BB2 3
$strBB4 :
,BB: ;
nullableBB< D
:BBD E
falseBBF K
)BBK L
,BBL M
AutherIdCC 
=CC 
tableCC $
.CC$ %
ColumnCC% +
<CC+ ,
intCC, /
>CC/ 0
(CC0 1
typeCC1 5
:CC5 6
$strCC7 @
,CC@ A
nullableCCB J
:CCJ K
falseCCL Q
)CCQ R
,CCR S
TextDD 
=DD 
tableDD  
.DD  !
ColumnDD! '
<DD' (
stringDD( .
>DD. /
(DD/ 0
typeDD0 4
:DD4 5
$strDD6 <
,DD< =
nullableDD> F
:DDF G
falseDDH M
)DDM N
,DDN O
ContentEE 
=EE 
tableEE #
.EE# $
ColumnEE$ *
<EE* +
stringEE+ 1
>EE1 2
(EE2 3
typeEE3 7
:EE7 8
$strEE9 ?
,EE? @
nullableEEA I
:EEI J
falseEEK P
)EEP Q
,EEQ R
PostIdFF 
=FF 
tableFF "
.FF" #
ColumnFF# )
<FF) *
intFF* -
>FF- .
(FF. /
typeFF/ 3
:FF3 4
$strFF5 >
,FF> ?
nullableFF@ H
:FFH I
falseFFJ O
)FFO P
,FFP Q

ResponseIdGG 
=GG  
tableGG! &
.GG& '
ColumnGG' -
<GG- .
stringGG. 4
>GG4 5
(GG5 6
typeGG6 :
:GG: ;
$strGG< B
,GGB C
nullableGGD L
:GGL M
falseGGN S
)GGS T
,GGT U
DateTimeHH 
=HH 
tableHH $
.HH$ %
ColumnHH% +
<HH+ ,
DateTimeHH, 4
>HH4 5
(HH5 6
typeHH6 :
:HH: ;
$strHH< V
,HHV W
nullableHHX `
:HH` a
falseHHb g
)HHg h
,HHh i
urlII 
=II 
tableII 
.II  
ColumnII  &
<II& '
stringII' -
>II- .
(II. /
typeII/ 3
:II3 4
$strII5 ;
,II; <
nullableII= E
:IIE F
falseIIG L
)IIL M
,IIM N
LikesJJ 
=JJ 
tableJJ !
.JJ! "
ColumnJJ" (
<JJ( )
intJJ) ,
>JJ, -
(JJ- .
typeJJ. 2
:JJ2 3
$strJJ4 =
,JJ= >
nullableJJ? G
:JJG H
falseJJI N
)JJN O
}KK 
,KK 
constraintsLL 
:LL 
tableLL "
=>LL# %
{MM 
tableNN 
.NN 

PrimaryKeyNN $
(NN$ %
$strNN% 3
,NN3 4
xNN5 6
=>NN7 9
xNN: ;
.NN; <
IdNN< >
)NN> ?
;NN? @
tableOO 
.OO 

ForeignKeyOO $
(OO$ %
namePP 
:PP 
$strPP 9
,PP9 :
columnQQ 
:QQ 
xQQ  !
=>QQ" $
xQQ% &
.QQ& '
PostIdQQ' -
,QQ- .
principalTableRR &
:RR& '
$strRR( /
,RR/ 0
principalColumnSS '
:SS' (
$strSS) -
,SS- .
onDeleteTT  
:TT  !
ReferentialActionTT" 3
.TT3 4
CascadeTT4 ;
)TT; <
;TT< =
tableUU 
.UU 

ForeignKeyUU $
(UU$ %
nameVV 
:VV 
$strVV A
,VVA B
columnWW 
:WW 
xWW  !
=>WW" $
xWW% &
.WW& '

ResponseIdWW' 1
,WW1 2
principalTableXX &
:XX& '
$strXX( 3
,XX3 4
principalColumnYY '
:YY' (
$strYY) -
,YY- .
onDeleteZZ  
:ZZ  !
ReferentialActionZZ" 3
.ZZ3 4
CascadeZZ4 ;
)ZZ; <
;ZZ< =
}[[ 
)[[ 
;[[ 
migrationBuilder]] 
.]] 
CreateIndex]] (
(]]( )
name^^ 
:^^ 
$str^^ .
,^^. /
table__ 
:__ 
$str__ 
,__ 
column`` 
:`` 
$str`` '
)``' (
;``( )
migrationBuilderbb 
.bb 
CreateIndexbb (
(bb( )
namecc 
:cc 
$strcc '
,cc' (
tabledd 
:dd 
$strdd 
,dd 
columnee 
:ee 
$stree  
)ee  !
;ee! "
migrationBuildergg 
.gg 
CreateIndexgg (
(gg( )
namehh 
:hh 
$strhh +
,hh+ ,
tableii 
:ii 
$strii "
,ii" #
columnjj 
:jj 
$strjj  
)jj  !
;jj! "
migrationBuilderll 
.ll 
CreateIndexll (
(ll( )
namemm 
:mm 
$strmm /
,mm/ 0
tablenn 
:nn 
$strnn "
,nn" #
columnoo 
:oo 
$stroo $
)oo$ %
;oo% &
}pp 	
	protectedss 
overridess 
voidss 
Downss  $
(ss$ %
MigrationBuilderss% 5
migrationBuilderss6 F
)ssF G
{tt 	
migrationBuilderuu 
.uu 
	DropTableuu &
(uu& '
namevv 
:vv 
$strvv !
)vv! "
;vv" #
migrationBuilderxx 
.xx 
	DropTablexx &
(xx& '
nameyy 
:yy 
$stryy 
)yy 
;yy 
migrationBuilder{{ 
.{{ 
	DropTable{{ &
({{& '
name|| 
:|| 
$str|| 
)|| 
;||  
}}} 	
}~~ 
} ¯
zC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Entities\ResponseEntity.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Entities '
{ 
public 

class 
ResponseEntity 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
int 
AuthorId 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
Content		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
=		, -
string		. 4
.		4 5
Empty		5 :
;		: ;
public

 
int

 
PostId

 
{

 
get

 
;

  
set

! $
;

$ %
}

& '
public 
int 

ResponseId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Audience 
{  
get" %
;% &
set' *
;* +
}, -
=. /
string0 6
.6 7
Empty7 <
;< =
public 
DateTime 
DateTime  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
Url 
{ 
get 
;  
set! $
;$ %
}& '
=( )
string* 0
.0 1
Empty1 6
;6 7
public 
int 
Likes 
{ 
get 
; 
set  #
;# $
}% &
} 
} ä
vC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Entities\PostEntity.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Entities '
{ 
public 

class 

PostEntity 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
Title

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
=

* +
string

, 2
.

2 3
Empty

3 8
;

8 9
public 
string 
Content 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
string. 4
.4 5
Empty5 :
;: ;
public 
int 
AuthorId 
{ 
get !
;! "
set# &
;& '
}( )
public 
DateTime 
DateTime  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
Audience 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
string/ 5
.5 6
Empty6 ;
;; <
public 
string 
Url 
{ 
get 
;  
set! $
;$ %
}& '
=( )
string* 0
.0 1
Empty1 6
;6 7
public 
int 
ForumId 
{ 
get  
;  !
set" %
;% &
}' (
} 
} §
vC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Entities\LikeEntity.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Entities '
{ 
public 

class 

LikeEntity 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
int 
PostId 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 

ResponseId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
UserId 
{ 
get  
;  !
set" %
;% &
}' (
}		 
}

 ·	
wC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Entities\ForumEntity.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Entities '
{ 
public 

class 
ForumEntity 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
CategoryName "
{# $
get% (
;( )
set* -
;- .
}/ 0
=1 2
string3 9
.9 :
Empty: ?
;? @
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
=0 1
string2 8
.8 9
Empty9 >
;> ?
public 
string 
Audience 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
string/ 5
.5 6
Empty6 ;
;; <
}		 
}

 à
xC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumRepositoryLayer\Entities\ForumContext.cs
	namespace 	 
ForumRepositoryLayer
 
. 
Entities '
{ 
public 

class 
ForumContext 
: 
	DbContext  )
{ 
public 
ForumContext 
( 
DbContextOptions ,
<, -
ForumContext- 9
>9 :
options; B
)B C
:D E
baseF J
(J K
optionsK R
)R S
{		 	
}		
 
public 
DbSet 
< 
ForumEntity  
>  !
Forums" (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
DbSet 
< 

PostEntity 
>  
Posts! &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
DbSet 
< 
ResponseEntity #
># $
	Responses% .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
DbSet 
< 

LikeEntity 
>  
Likes! &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
} 
} 