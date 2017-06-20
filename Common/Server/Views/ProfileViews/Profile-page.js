$(document).ready(function(){
	let trial = $.get( {
		url: "http://comeet.azurewebsites.net/Tags"
	}
		, function( data ) {
  			Console.log(data);
	});
});	
