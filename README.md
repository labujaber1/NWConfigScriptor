# NWConfigScriptor
Used .NETCore. Win Forms was chosen for construction speed and design experimentation.

 This is a simple win form program aimed at students learning routing who are tired of typing
in repeated configuration commands for devices. It is not a learning tool to teach routing 
configuration as Cisco and packet tracer do a great job of doing that. It is essentially a 
tool to construct config commands to copy and paste into network devices CLI. It also allows 
the config commands to be saved into a text file for the user to choose location and filename.

 Text files contain basic routing commands that are used up to level 6 (UK degree) with 
a question mark to identify additional user input. This includes ip addresses, hostnames, 
network addresses, and so forth. Text files have been chosen as they are small in size
and easier to manage in such a small program.

 The tool will only look for .txt file extensions stored in a folder "ConfigTextFiles" 
which when built are copied (set to 'copy if newer') to bin/debug. They will be listed in
a combo box for the user to select and the contents displayed in a list box. Any "show.." 
commands are displayed in a seperate text box as read only for additional testing help.

 Double click a command in the list box and it will append to a rich text box for editing
including adding user essential input as previously mentioned. To insert a command between
commands, create a new line, click once a command and hit the insert button which will 
copy at the cursor. 

 Once completed right click in the editor to copy to the clipboard ready to paste. Ctl+C 
will also work if preferred. A select all and copy option is included as well as a seperate
option. 

 The config file can be constructed by switching between text files as the editor is only
cleared by selecting the "clear editor" button. Schroll bars are obviously included in all
text boxes.

 The user is free to adjust the text files holding the config/show commands or add new ones
as long as they are .txt and added to the ConfigTextFiles folder, no other extensions are 
looked for.
 
 Help, Load file, save file, and append to file options added to right click menu in the 
editor. The load file reads in file content into the editor for editing or appending and
so will need to overwrite existing file when saving. Append to file allows commands to be
added to files without the need for them to be opened in the editor.
 
 Version 1.2 will consider if there is a need to update devices straight away or used as
an add on to packet tracer.
 
