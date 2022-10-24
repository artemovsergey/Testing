$('#id_files').change(function() {
    var input = $(this)[0];
    if ( input.files && input.files[0] ) {
      if ( input.files[0].type.match('image.*') ) {
        var reader = new FileReader();
        reader.onload = function(e) { $('#preview').attr('src', e.target.result); }
        reader.readAsDataURL(input.files[0]);
      } else console.log('is not image mime type');
    } else console.log('not isset files data or files API not supordet');
  });

  oninput = function() {
    document.getElementById('title-card').innerHTML = document.getElementById("title-inpt").value;
    document.getElementById('desc-card').innerHTML = document.getElementById("desc-txt").value;
    document.getElementById('len-card').innerHTML = document.getElementById("len-inpt").value;
    document.getElementById('dur-card').innerHTML = document.getElementById("dur-inpt").value;
        if (document.getElementById('chck-inpt').checked == true) {
            document.getElementById('pop-card').hidden = false;
        } else {
            document.getElementById('pop-card').hidden = true;
        }
    };