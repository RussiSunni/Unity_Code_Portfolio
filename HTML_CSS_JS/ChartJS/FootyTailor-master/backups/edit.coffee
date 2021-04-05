# RojobaCo.Router.register 'edit', (route) ->
#     teamnum = localStorage.getItem "name"
#     playerimage = ''
#     # $('input[type="file"]').change ()->
#     #     canvas  = $("#canvas")
#     #     context = canvas.get(0).getContext("2d")
#     #     $result = $('#result')
#     #     $('#PlayerForm input[type="file"]').each ->
#     #         console.log 'bark'
#     #         if this.files and this.files[0]
#     #             console.log this.files
#     #             if this.files[0].type.match(/^image\//)
#     #                 reader = new FileReader()
#     #                 reader.onload = (evt) ->
#     #                     img = new Image()
#     #                     img.onload = () ->
#     #                         context.canvas.height = img.height
#     #                         context.canvas.width  = img.width
#     #                         context.drawImage(img, 0, 0)
#     #                         cropper = canvas.cropper ({
#     #                             aspectRatio: 4 / 4})
                            
#     #                         $('#btnCrop').click () ->
#     #                             # // Get a string base 64 data url
#     #                             croppedImageDataURL = canvas.cropper('getCroppedCanvas').toDataURL('image/png')
#     #                             $('#playerphoto').attr 'src', croppedImageDataURL
#     #                             console.log croppedImageDataURL
#     #                         $('#btnRestore').click () ->
#     #                             canvas.cropper 'reset'
#     #                             $result.empty()
#     #                     img.src = evt.target.result
#     #                 reader.readAsDataURL this.files[0]
#     #             else 
#     #                 alert 'Invalid file type! Please select an image file.'
#     #         else
#     #             alert 'No file(s) selected.'

#     $.get "http://local.footietailor.com:81/team/" + teamnum , ( team ) ->  
#         $(".teamname h1").html "Team name: " + team[0].name
#     $.get "http://local.footietailor.com:81/player/" + route.id , ( player ) -> 
#         $( '#firstname' ).val player[0].firstname
#         $( '#lastname' ).val player[0].lastname
#         $( '#name' ).val player[0].name
#         $( '#dob' ).val player[0].dob
#         $( '#picturepicker' ).val player[0].photo   
#         imagedisplay = '<img src="'+player[0].photo+'" alt="photo" width="150" height="150" id="playerphoto">'
#         $(imagedisplay).insertBefore('#photo')    
   
  
    
#     $('#photo').change () ->
#         $('#imageselector').empty()
#         tagcontent = document.createElement("div");
#         tagcontent.innerHTML = '<canvas id="canvas"> Your browser does not support the HTML5 canvas element.</canvas> <p>
#         <input type="button" id="btnCrop" value="Crop" /><input type="button" id="btnRestore" value="Restore" /></p>'
#         $("#imageselector").append(tagcontent);
#         canvas  = $('#canvas')
#         context = canvas.get(0).getContext("2d")
#         $result = $('#result')
#         if this.files and this.files[0]
#             if this.files[0].type.match(/^image\//)
#                 reader = new FileReader()
#                 reader.onload = (evt) ->
#                     img = new Image()
#                     img.onload = () ->
#                         context.canvas.height = img.height
#                         context.canvas.width  = img.width
#                         context.drawImage(img, 0, 0)
#                         cropper = canvas.cropper ({
#                             aspectRatio: 4 / 4})
#                         $('#btnCrop').click () ->
#                             croppedImageDataURL = canvas.cropper('getCroppedCanvas').toDataURL('image/png')
#                             $('#playerphoto').attr 'src', croppedImageDataURL
#                             playerimage = croppedImageDataURL
#                         $('#btnRestore').click () ->
#                             canvas.cropper 'reset'
#                             $result.empty()
#                     img.src = evt.target.result
#                 reader.readAsDataURL this.files[0]
#             else 
#                     alert 'Invalid file type! Please select an image file.'
#         else
#             alert 'No file(s) selected.'


#     fileToBinary = (input, callback)->
#         acceptType = ["image/png", "image/jpeg"] 
#         data = null
#         for file in input.files
#             if file != null
#                 reader = new FileReader()
#                 reader.onload = (evt) ->
#                     callback evt.target.result
#                     return
#                 reader.readAsDataURL file
#             return    
#         return data
#     savePlayer = (player) ->
#         $.ajax
#             type: 'POST'
#             url: 'http://local.footietailor.com:81/players/' + route.id 
#             data: JSON.stringify player
#             dataType: 'text'
#         .done (data, jqXhr, status) -> 
#             cookiestore = window.localStorage.getItem("name"); 
#             return window.location = "#players/" + cookiestore
            
#         .fail (jqXhr, status, error) ->
#             alert 'An error occurred: ' + error #solve this
#             return

#          return
    
#     $('#PlayerForm').validate {
#         rules:
#             firstname:
#                 required: true
#                 minlength: 3 
#             lastname:
#                 required: true
#                 minlength: 3 
#         messages:
#              firstname:
#                 required: 'First name is required.'
#                 minlength: 'First name must have at least 2 letters'
#              lastname:
#                 required: 'Last name is required.'
#                 minlength: 'Last name must have at least 2 letters'
#         submitHandler: (form) ->
#             obj = {}
#             $('#PlayerForm input[type!="file"]').each ->
#                 obj[$(this).attr('id')] = $(this).val() unless $(this).val() is ""
#                 return

#             if form['photo'].files.length > 0
#                 obj['photo'] = playerimage                      
#                 savePlayer obj
#                 return
#             else
#                 savePlayer obj
#             return 
#     }
#     return