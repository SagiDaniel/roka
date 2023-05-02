# Backend
## Seeder
Schema::create(’papirzsebkendok’, function (Blueprint $table)){
	$table->id();
	$table->string(’nev’,50);
	$table->string(’jellemzo’,100)->	nullable();	[nem kotelezo]
	$table->foreignId(’gyartyo_id’)->referended(’gyartok’,’id’);   	[Fk]
}
php artisan migrate:(re)fresh –seed

## Model
###	(papirzsebkendo)				gyartok papirzsebkendo 1:N 
protected $table = ’papirzsebkendo’;
publick $timestamp = false;
publi function gyarto(){
	return $this->belongsTo(gyartok::class, ’gyarto_id’,’id’)
}
###	(gyarok)
protected $fillable=[’nev’,’jellemzo’,’reteg’,’darab’,’gyarto_id’]
p function papirtzsebkendo(){
	return $this->hasMany(papirzsebkendok::class,gyarto_id,id)
}
## Request – Validálás
authorize()
true;
rules(){
	return[
		nev=>requered|numeric|min:0,
		jellemzo=>nullable,
		ar=>required|string|max:50
		gyarto_id= > exist:gyarok,id
]
}

Resource
php artisan mage:resource Papirzsebkendo
	toArray($request){
	id=>$this->id,
	gyartok=>this->gyarto
}
Route
Route::get(’/papirzsebkendok’, [PapirzsebkendoController::class],’idnex’)->whereNumber(id)  ->name(papirzsebkendo.index);
Controller (papirzsebekndo)
p function index(){
	$papirzsebkendo=Papirzsenbkendok::all();
	returnd PapirzsebkendoResource($papirzsebkendo);
}
p function show($id){
	$papirzsebkendo=Papirzsenbkendok::FindOrFail($d);
returnd PapirzsebkendoResource($papirzsebkendo);
}
p function store(Papirzsebkendo $request){
	$data=$request->validated();
	$uj = Papirzsebkendok::cvreate($date)
	return new PapirzsebkendokResource($uj);
}
