†>
xC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\ResponseService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
{ 
public		 

class		 
ResponseService		  
:		! "
IResponseService		# 3
{

 
private 
readonly 
IResponseRepository ,
_responseRepository- @
;@ A
public 
ResponseService 
( 
IResponseRepository 2
responseRepository3 E
)E F
{ 	
_responseRepository 
=  !
responseRepository" 4
;4 5
} 	
public 
async 
Task 
< 
ResponseModel '
>' (
Create) /
(/ 0
ResponseModel0 =
p> ?
)? @
{ 	
ResponseEntity 
responseEntity )
=* +
new, /
ResponseEntity0 >
(> ?
)? @
{ 
Content 
= 
p 
. 
Content #
,# $
AuthorId 
= 
p 
. 
AuthorId %
,% &
DateTime 
= 
p 
. 
DateTime %
,% &
Audience 
= 
p 
. 
Audience %
,% &
Url 
= 
p 
. 
Url 
, 

ResponseId 
= 
p 
. 

ResponseId )
} 
; 
ResponseEntity !
createdResponseEntity 0
=1 2
await3 8
_responseRepository9 L
.L M
AddAsyncM U
(U V
responseEntityV d
)d e
;e f
return 
TransformBack  
(  !!
createdResponseEntity! 6
)6 7
;7 8
} 	
public!! 
async!! 
Task!! 
Update!!  
(!!  !
ResponseModel!!! .
Response!!/ 7
)!!7 8
{"" 	
ResponseEntity## 
existingResponse## +
=##, -
await##. 3
_responseRepository##4 G
.##G H
GetByIdAsync##H T
(##T U
Response##U ]
.##] ^
Id##^ `
)##` a
;##a b
if$$ 
($$ 
existingResponse$$  
!=$$! #
null$$$ (
)$$( )
{%% 
existingResponse&&  
.&&  !
Content&&! (
=&&) *
Response&&+ 3
.&&3 4
Content&&4 ;
;&&; <
existingResponse''  
.''  !
DateTime''! )
=''* +
Response'', 4
.''4 5
DateTime''5 =
;''= >
existingResponse((  
.((  !
Audience((! )
=((* +
Response((, 4
.((4 5
Audience((5 =
;((= >
_responseRepository** #
.**# $
Update**$ *
(*** +
existingResponse**+ ;
)**; <
;**< =
}++ 
else,, 
{-- 
throw.. 
new.. 
ArgumentException.. +
(..+ ,
$str.., S
)..S T
;..T U
}// 
}00 	
public22 
async22 
Task22 
Delete22  
(22  !
ResponseModel22! .
Response22/ 7
)227 8
{33 	
ResponseEntity44 
existingResponse44 +
=44, -
await44. 3
_responseRepository444 G
.44G H
GetByIdAsync44H T
(44T U
Response44U ]
.44] ^
Id44^ `
)44` a
;44a b
if55 
(55 
existingResponse55  
!=55! #
null55$ (
)55( )
{66 
_responseRepository77 #
.77# $
Remove77$ *
(77* +
existingResponse77+ ;
)77; <
;77< =
}88 
else99 
{:: 
throw;; 
new;; 
ArgumentException;; +
(;;+ ,
$str;;, Y
);;Y Z
;;;Z [
}<< 
}== 	
public?? 
async?? 
Task?? 
<?? 
ResponseModel?? '
>??' (
Get??) ,
(??, -
int??- 0
id??1 3
)??3 4
{@@ 	
ResponseEntityAA 
ResponseEntityAA )
=AA* +
awaitAA, 1
_responseRepositoryAA2 E
.AAE F
GetByIdAsyncAAF R
(AAR S
idAAS U
)AAU V
;AAV W
returnBB 
TransformBackBB  
(BB  !
ResponseEntityBB! /
)BB/ 0
;BB0 1
}CC 	
privateEE 
ResponseModelEE 
TransformBackEE +
(EE+ ,
ResponseEntityEE, :
rEE; <
)EE< =
{FF 	
returnGG 
newGG 
ResponseModelGG $
(GG$ %
)GG% &
{HH 
IdII 
=II 
rII 
.II 
IdII 
,II 
ContentJJ 
=JJ 
rJJ 
.JJ 
ContentJJ #
,JJ# $
AuthorIdKK 
=KK 
rKK 
.KK 
AuthorIdKK %
,KK% &
DateTimeLL 
=LL 
rLL 
.LL 
DateTimeLL %
,LL% &
AudienceMM 
=MM 
rMM 
.MM 
AudienceMM %
,MM% &
UrlNN 
=NN 
rNN 
.NN 
UrlNN 
,NN 

ResponseIdOO 
=OO 
rOO 
.OO 

ResponseIdOO )
}PP 
;PP 
}QQ 	
publicSS 
asyncSS 
TaskSS 
<SS 
ListSS 
<SS 
ResponseModelSS ,
>SS, -
>SS- .
GetAllSS/ 5
(SS5 6
intSS6 9
postIdSS: @
)SS@ A
{TT 	
ListUU 
<UU 
ResponseEntityUU 
>UU  
	ResponsesUU! *
=UU+ ,
awaitUU- 2
_responseRepositoryUU3 F
.UUF G
GetByPostIdUUG R
(UUR S
postIdUUS Y
)UUY Z
;UUZ [
ListWW 
<WW 
ResponseModelWW 
>WW 
ResponseModelsWW  .
=WW/ 0
newWW1 4
ListWW5 9
<WW9 :
ResponseModelWW: G
>WWG H
(WWH I
)WWI J
;WWJ K
foreachXX 
(XX 
ResponseEntityXX #
rXX$ %
inXX& (
	ResponsesXX) 2
)XX2 3
{YY 
ResponseModelsZZ 
.ZZ 
AddZZ "
(ZZ" #
newZZ# &
ResponseModelZZ' 4
(ZZ4 5
)ZZ5 6
{[[ 
Id\\ 
=\\ 
r\\ 
.\\ 
Id\\ 
,\\ 
Content]] 
=]] 
r]] 
.]]  
Content]]  '
,]]' (
AuthorId^^ 
=^^ 
r^^  
.^^  !
AuthorId^^! )
,^^) *
DateTime__ 
=__ 
r__  
.__  !
DateTime__! )
,__) *
Audience`` 
=`` 
r``  
.``  !
Audience``! )
,``) *
Urlaa 
=aa 
raa 
.aa 
Urlaa 
,aa  

ResponseIdbb 
=bb  
rbb! "
.bb" #

ResponseIdbb# -
}cc 
)cc 
;cc 
}dd 
returnff 
ResponseModelsff !
;ff! "
}gg 	
}hh 
}ii ô@
tC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\PostService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
{ 
public 

class 
PostService 
: 
IPostService +
{		 
private

 
readonly

 
IPostRepository

 (
_postRepository

) 8
;

8 9
public 
PostService 
( 
IPostRepository *
postRepository+ 9
)9 :
{ 	
_postRepository 
= 
postRepository ,
;, -
} 	
public 
async 
Task 
< 
	PostModel #
># $
Create% +
(+ ,
	PostModel, 5
post6 :
): ;
{ 	

PostEntity 

postEntity !
=" #
new$ '

PostEntity( 2
(2 3
)3 4
{ 
Title 
= 
post 
. 
Title "
," #
Content 
= 
post 
. 
Content &
,& '
AuthorId 
= 
post 
.  
AuthorId  (
,( )
DateTime 
= 
post 
.  
DateTime  (
,( )
Audience 
= 
post 
.  
Audience  (
,( )
Url 
= 
post 
. 
Url 
, 
ForumId 
= 
post 
. 
ForumId &
} 
; 

PostEntity 
createdPostEntity (
=) *
await+ 0
_postRepository1 @
.@ A
AddAsyncA I
(I J

postEntityJ T
)T U
;U V
return 
TransformBack  
(  !
createdPostEntity! 2
)2 3
;3 4
}   	
public"" 
async"" 
Task"" 
Update""  
(""  !
	PostModel""! *
post""+ /
)""/ 0
{## 	

PostEntity$$ 
existingPost$$ #
=$$$ %
await$$& +
_postRepository$$, ;
.$$; <
GetByIdAsync$$< H
($$H I
post$$I M
.$$M N
Id$$N P
)$$P Q
;$$Q R
if%% 
(%% 
existingPost%% 
!=%% 
null%%  $
)%%$ %
{&& 
existingPost'' 
.'' 
Title'' "
=''# $
post''% )
.'') *
Title''* /
;''/ 0
existingPost(( 
.(( 
Content(( $
=((% &
post((' +
.((+ ,
Content((, 3
;((3 4
existingPost)) 
.)) 
DateTime)) %
=))& '
post))( ,
.)), -
DateTime))- 5
;))5 6
existingPost** 
.** 
Audience** %
=**& '
post**( ,
.**, -
Audience**- 5
;**5 6
_postRepository,, 
.,,  
Update,,  &
(,,& '
existingPost,,' 3
),,3 4
;,,4 5
}-- 
else.. 
{// 
throw00 
new00 
ArgumentException00 +
(00+ ,
$str00, O
)00O P
;00P Q
}11 
}22 	
public44 
async44 
Task44 
Delete44  
(44  !
	PostModel44! *
post44+ /
)44/ 0
{55 	

PostEntity66 
existingPost66 #
=66$ %
await66& +
_postRepository66, ;
.66; <
GetByIdAsync66< H
(66H I
post66I M
.66M N
Id66N P
)66P Q
;66Q R
if77 
(77 
existingPost77 
!=77 
null77  $
)77$ %
{88 
_postRepository99 
.99  
Remove99  &
(99& '
existingPost99' 3
)993 4
;994 5
}:: 
else;; 
{<< 
throw== 
new== 
ArgumentException== +
(==+ ,
$str==, U
)==U V
;==V W
}>> 
}?? 	
publicAA 
asyncAA 
TaskAA 
<AA 
	PostModelAA #
>AA# $
GetAA% (
(AA( )
intAA) ,
idAA- /
)AA/ 0
{BB 	

PostEntityCC 

postEntityCC !
=CC" #
awaitCC$ )
_postRepositoryCC* 9
.CC9 :
GetByIdAsyncCC: F
(CCF G
idCCG I
)CCI J
;CCJ K
returnDD 
TransformBackDD  
(DD  !

postEntityDD! +
)DD+ ,
;DD, -
}EE 	
privateGG 
	PostModelGG 
TransformBackGG '
(GG' (

PostEntityGG( 2

postEntityGG3 =
)GG= >
{HH 	
returnII 
newII 
	PostModelII  
(II  !
)II! "
{JJ 
IdKK 
=KK 

postEntityKK 
.KK  
IdKK  "
,KK" #
TitleLL 
=LL 

postEntityLL "
.LL" #
TitleLL# (
,LL( )
ContentMM 
=MM 

postEntityMM $
.MM$ %
ContentMM% ,
,MM, -
AuthorIdNN 
=NN 

postEntityNN %
.NN% &
AuthorIdNN& .
,NN. /
AudienceOO 
=OO 

postEntityOO %
.OO% &
AudienceOO& .
,OO. /
DateTimePP 
=PP 

postEntityPP %
.PP% &
DateTimePP& .
,PP. /
ForumIdQQ 
=QQ 

postEntityQQ $
.QQ$ %
ForumIdQQ% ,
}RR 
;RR 
}SS 	
publicUU 
asyncUU 
TaskUU 
<UU 
ListUU 
<UU 
	PostModelUU (
>UU( )
>UU) *
GetAllUU+ 1
(UU1 2
intUU2 5
forumIdUU6 =
)UU= >
{VV 	
ListWW 
<WW 

PostEntityWW 
>WW 
postsWW "
=WW# $
awaitWW% *
_postRepositoryWW+ :
.WW: ;
GetByForumIdWW; G
(WWG H
forumIdWWH O
)WWO P
;WWP Q
ListYY 
<YY 
	PostModelYY 
>YY 

postModelsYY &
=YY' (
newYY) ,
ListYY- 1
<YY1 2
	PostModelYY2 ;
>YY; <
(YY< =
)YY= >
;YY> ?
foreachZZ 
(ZZ 

PostEntityZZ 
postZZ  $
inZZ% '
postsZZ( -
)ZZ- .
{[[ 

postModels\\ 
.\\ 
Add\\ 
(\\ 
new\\ "
	PostModel\\# ,
(\\, -
)\\- .
{\\/ 0
Id\\1 3
=\\4 5
post\\6 :
.\\: ;
Id\\; =
,\\= >
Title\\? D
=\\E F
post\\G K
.\\K L
Title\\L Q
,\\Q R
Audience\\S [
=\\\ ]
post\\^ b
.\\b c
Audience\\c k
,\\k l
Content\\m t
=\\u v
post\\w {
.\\{ |
Content	\\| É
,
\\É Ñ
AuthorId
\\Ö ç
=
\\é è
post
\\ê î
.
\\î ï
AuthorId
\\ï ù
,
\\ù û
DateTime
\\ü ß
=
\\® ©
post
\\™ Æ
.
\\Æ Ø
DateTime
\\Ø ∑
,
\\∑ ∏
ForumId
\\π ¿
=
\\¡ ¬
post
\\√ «
.
\\« »
ForumId
\\» œ
,
\\œ –
Url
\\— ‘
=
\\’ ÷
post
\\◊ €
.
\\€ ‹
Url
\\‹ ﬂ
}
\\‡ ·
)
\\· ‚
;
\\‚ „
}]] 
return__ 

postModels__ 
;__ 
}`` 	
}aa 
}bb ™<
tC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\LikeService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
{ 
public 

class 
LikeService 
: 
ILikeService +
{		 
private

 
readonly

 
ILikeRepository

 (
_likeRepository

) 8
;

8 9
public 
LikeService 
( 
ILikeRepository *
likeRepository+ 9
)9 :
{ 	
_likeRepository 
= 
likeRepository ,
;, -
} 	
public 
async 
Task 
< 
	LikeModel #
># $
Create% +
(+ ,
	LikeModel, 5
like6 :
): ;
{ 	

LikeEntity 

likeEntity !
=" #
new$ '

LikeEntity( 2
(2 3
)3 4
{ 
PostId 
= 
like 
. 
PostId $
,$ %

ResponseId 
= 
like !
.! "

ResponseId" ,
,, -
UserId 
= 
like 
. 
UserId $
} 
; 

LikeEntity 
l 
= 
await  
_likeRepository! 0
.0 1
AddAsync1 9
(9 :

likeEntity: D
)D E
;E F
return 
new 
	LikeModel  
(  !
)! "
{ 
Id 
= 
l 
. 
Id 
, 
PostId 
= 
l 
. 
PostId !
,! "

ResponseId 
= 
l 
. 

ResponseId )
,) *
UserId   
=   
l   
.   
UserId   !
}!! 
;!! 
}"" 	
public## 
void## 
Delete## 
(## 
	LikeModel## $
like##% )
)##) *
{$$ 	

LikeEntity%% 

likeEntity%% !
=%%" #
new%%$ '

LikeEntity%%( 2
(%%2 3
)%%3 4
{&& 
Id'' 
='' 
like'' 
.'' 
Id'' 
,'' 
PostId(( 
=(( 
like(( 
.(( 
PostId(( $
,(($ %

ResponseId)) 
=)) 
like)) !
.))! "

ResponseId))" ,
,)), -
UserId** 
=** 
like** 
.** 
UserId** $
}++ 
;++ 
_likeRepository,, 
.,, 
Remove,, "
(,," #

likeEntity,,# -
),,- .
;,,. /
}-- 	
public// 
async// 
Task// 
<// 
List// 
<// 
	LikeModel// (
>//( )
>//) *

GetAllPost//+ 5
(//5 6
int//6 9
postId//: @
)//@ A
{00 	
List11 
<11 

LikeEntity11 
>11 
likes11 "
=11# $
await11& +
_likeRepository11, ;
.11; <
GetAllLikesPost11< K
(11K L
postId11L R
)11R S
;11S T
List33 
<33 
	LikeModel33 
>33 

likemodels33 &
=33' (
new33) ,
List33- 1
<331 2
	LikeModel332 ;
>33; <
(33< =
)33= >
;33> ?
foreach44 
(44 
var44 

likeEntity44 "
in44# %
likes44& +
)44+ ,
{55 

likemodels66 
.66 
Add66 
(66 
new66 "
	LikeModel66# ,
(66, -
)66- .
{66/ 0
Id661 3
=663 4

likeEntity665 ?
.66? @
Id66@ B
,66B C
PostId66D J
=66K L

likeEntity66M W
.66W X
PostId66X ^
,66^ _
UserId66` f
=66g h

likeEntity66i s
.66s t
UserId66t z
}66{ |
)66| }
;66} ~
}77 
return88 

likemodels88 
;88 
}99 	
public:: 
async:: 
Task:: 
<:: 
List:: 
<:: 
	LikeModel:: (
>::( )
>::) *
GetAllResponse::+ 9
(::9 :
int::: =

responseId::> H
)::H I
{;; 	
List<< 
<<< 

LikeEntity<< 
><< 
likes<< "
=<<# $
await<<% *
_likeRepository<<+ :
.<<: ;
GetAllLikesPost<<; J
(<<J K

responseId<<K U
)<<U V
;<<V W
List>> 
<>> 
	LikeModel>> 
>>> 

likemodels>> &
=>>' (
new>>) ,
List>>- 1
<>>1 2
	LikeModel>>2 ;
>>>; <
(>>< =
)>>= >
;>>> ?
foreach?? 
(?? 
var?? 

likeEntity?? #
in??$ &
likes??' ,
)??, -
{@@ 

likemodelsAA 
.AA 
AddAA 
(AA 
newAA "
	LikeModelAA# ,
(AA, -
)AA- .
{AA/ 0
IdAA1 3
=AA4 5

likeEntityAA6 @
.AA@ A
IdAAA C
,AAC D

ResponseIdAAE O
=AAP Q

likeEntityAAR \
.AA\ ]

ResponseIdAA] g
,AAg h
UserIdAAi o
=AAp q

likeEntityAAr |
.AA| }
UserId	AA} É
}
AAÑ Ö
)
AAÖ Ü
;
AAÜ á
}BB 
returnCC 

likemodelsCC 
;CC 
}DD 	
publicEE 
asyncEE 
TaskEE 
<EE 
ListEE 
<EE 
	LikeModelEE (
>EE( )
>EE) *

GetAllUserEE+ 5
(EE5 6
intEE6 9
userIdEE: @
)EE@ A
{FF 	
ListGG 
<GG 

LikeEntityGG 
>GG 
likesGG "
=GG# $
awaitGG% *
_likeRepositoryGG+ :
.GG: ;
GetAllLikesPostGG; J
(GGJ K
userIdGGK Q
)GGQ R
;GGR S
ListII 
<II 
	LikeModelII 
>II 

likemodelsII &
=II' (
newII) ,
ListII- 1
<II1 2
	LikeModelII2 ;
>II; <
(II< =
)II= >
;II> ?
foreachJJ 
(JJ 
varJJ 

likeEntityJJ #
inJJ$ &
likesJJ' ,
)JJ, -
{KK 

likemodelsLL 
.LL 
AddLL 
(LL 
newLL "
	LikeModelLL# ,
(LL, -
)LL- .
{LL/ 0
IdLL1 3
=LL4 5

likeEntityLL6 @
.LL@ A
IdLLA C
,LLC D

ResponseIdLLE O
=LLP Q

likeEntityLLR \
.LL\ ]

ResponseIdLL] g
,LLg h
PostIdLLi o
=LLp q

likeEntityLLr |
.LL| }
PostId	LL} É
,
LLÉ Ñ
UserId
LLÖ ã
=
LLå ç

likeEntity
LLé ò
.
LLò ô
UserId
LLô ü
}
LL† °
)
LL° ¢
;
LL¢ £
}MM 
returnNN 

likemodelsNN 
;NN 
}OO 	
}PP 
}QQ —	
ÑC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\Interfaces\IResponseService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
.$ %

Interfaces% /
{ 
public 

	interface 
IResponseService %
{ 
Task 
< 
ResponseModel 
> 
Create "
(" #
ResponseModel# 0
p1 2
)2 3
;3 4
Task 
Update 
( 
ResponseModel !
Response" *
)* +
;+ ,
Task		 
Delete		 
(		 
ResponseModel		 !
Response		" *
)		* +
;		+ ,
Task

 
<

 
ResponseModel

 
>

 
Get

 
(

  
int

  #
id

$ &
)

& '
;

' (
Task 
< 
List 
< 
ResponseModel 
>  
>  !
GetAll" (
(( )
int) ,
postId- 3
)3 4
;4 5
} 
} ≠	
ÄC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\Interfaces\IPostService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
.$ %

Interfaces% /
{ 
public 

	interface 
IPostService !
{ 
Task 
< 
	PostModel 
> 
Create 
( 
	PostModel (
post) -
)- .
;. /
Task 
Update 
( 
	PostModel 
post "
)" #
;# $
Task		 
Delete		 
(		 
	PostModel		 
post		 "
)		" #
;		# $
Task

 
<

 
	PostModel

 
>

 
Get

 
(

 
int

 
id

  "
)

" #
;

# $
Task 
< 
List 
< 
	PostModel 
> 
> 
GetAll $
($ %
int% (
forumId) 0
)0 1
;1 2
} 
} ÿ

ÄC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\Interfaces\ILikeService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
.$ %

Interfaces% /
{ 
public 

	interface 
ILikeService !
{ 
Task 
< 
	LikeModel 
> 
Create 
( 
	LikeModel (
like) -
)- .
;. /
void 
Delete 
( 
	LikeModel 
like "
)" #
;# $
Task		 
<		 
List		 
<		 
	LikeModel		 
>		 
>		 

GetAllPost		 (
(		( )
int		) ,
postId		- 3
)		3 4
;		4 5
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
 
	LikeModel

 
>

 
>

 
GetAllResponse

 ,
(

, -
int

- 0

responseId

1 ;
)

; <
;

< =
Task 
< 
List 
< 
	LikeModel 
> 
> 

GetAllUser (
(( )
int) ,
userId- 3
)3 4
;4 5
} 
} Á
ÅC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\Interfaces\IForumService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
.$ %

Interfaces% /
{ 
public 

	interface 
IforumService "
{ 
Task 
< 
List 
< 

ForumModel 
> 
> 
	GetForums (
(( )
string) /
privacy0 7
)7 8
;8 9
} 
}		 ∆
uC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Services\ForumService.cs
	namespace 	
ForumServiceLayer
 
. 
Services $
{ 
public 

class 
ForumService 
: 
IforumService  -
{		 
private

 
readonly

 
IForumRepository

 )
_forumRepository

* :
;

: ;
public 
ForumService 
( 
IForumRepository ,
forumRepository- <
)< =
{ 	
_forumRepository 
= 
forumRepository .
;. /
} 	
public 
async 
Task 
< 
List 
< 

ForumModel )
>) *
>* +
	GetForums, 5
(5 6
string6 <
privacy= D
)D E
{ 	
List 
< 
ForumEntity 
> 
f 
=  !
await" '
_forumRepository( 8
.8 9
GetAllForums9 E
(E F
privacyF M
)M N
;N O
List 
< 

ForumModel 
> 
forums #
=$ %
new& )
List* .
<. /

ForumModel/ 9
>9 :
(: ;
); <
;< =
foreach 
( 
ForumEntity 
entity  &
in' )
f* +
)+ ,
{ 
forums 
. 
Add 
( 
new 

ForumModel  *
(* +
)+ ,
{ 
Id 
= 
entity 
.  
Id  "
," #
CategoryName  
=! "
entity# )
.) *
CategoryName* 6
,6 7
Description 
=  !
entity" (
.( )
Description) 4
,4 5
Audience 
= 
entity %
.% &
Audience& .
,. /
} 
) 
; 
}   
return!! 
forums!! 
;!! 
}"" 	
}## 
}$$ ∑

gC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder 
. 
Services 
. 
AddSwaggerGen 
( 
)  
;  !
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
if 
( 
app 
. 
Environment 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
) 
; 
} 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
Run 
( 
) 	
;	 
£
tC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Models\ResponseModel.cs
	namespace 	
ForumServiceLayer
 
. 
Models "
{ 
public 

class 
ResponseModel 
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
int 
AuthorId 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Content 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
string. 4
.4 5
Empty5 :
;: ;
public 
int 
PostId 
{ 
get 
;  
set! $
;$ %
}& '
public		 
int		 

ResponseId		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public

 
string

 
Audience

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
=

- .
string

/ 5
.

5 6
Empty

6 ;
;

; <
public 
DateTime 
DateTime  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
Url 
{ 
get 
;  
set! $
;$ %
}& '
=( )
string* 0
.0 1
Empty1 6
;6 7
public 
int 
Likes 
{ 
get 
; 
set  #
;# $
}% &
} 
} ÿ
pC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Models\PostModel.cs
	namespace 	
ForumServiceLayer
 
. 
Models "
{ 
public 

class 
	PostModel 
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
string 
Title 
{ 
get !
;! "
set# &
;& '
}( )
=* +
string, 2
.2 3
Empty3 8
;8 9
public 
string 
Content 
{ 
get  #
;# $
set% (
;( )
}* +
=, -
string. 4
.4 5
Empty5 :
;: ;
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
string		 
Audience		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
=		- .
string		/ 5
.		5 6
Empty		6 ;
;		; <
public

 
DateTime

 
DateTime

  
{

! "
get

# &
;

& '
set

( +
;

+ ,
}

- .
public 
string 
Url 
{ 
get 
;  
set! $
;$ %
}& '
=( )
string* 0
.0 1
Empty1 6
;6 7
public 
int 
ForumId 
{ 
get  
;  !
set" %
;% &
}' (
} 
} õ
pC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Models\LikeModel.cs
	namespace 	
ForumServiceLayer
 
. 
Models "
{ 
public 

class 
	LikeModel 
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
get 
;  
set! $
;$ %
}& '
}		 
}

 ´	
qC:\Users\maike\Articulation-Assessment-Platform\Forum-Service\ForumService\ForumServiceLayer\Models\ForumModel.cs
	namespace 	
ForumServiceLayer
 
. 
Models "
{ 
public 

class 

ForumModel 
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
 