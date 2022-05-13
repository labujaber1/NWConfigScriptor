# NWConfigScriptor
Used .NETCore. 

 This is a simple win form program aimed at students learning routing and are tired of typing in
repeated configuration commands for devices. It is not a learning tool to teach routing 
configuration as Cisco and packet tracer do a great job of doing that. It is essentially a tool 
to construct config commands to copy and paste into network devices CLI. It also allows 
the config commands to be saved into a text file with a date and time stamp added to 
"ConfigScript_".

 Text files contain basic routing commands that are used up to level 6 (UK degree) with 
a question mark to identify additional user input. This includes ip addresses, hostnames, 
network addresses, and so forth. Text files have been chosen as they are small in size
and easy to copy into packet tracer.

 The tool will only look for .txt file extensions stored in a folder "ConfigTextFiles" 
which when built are copied (set to 'copy if newer') to bin/debug. They will be listed in
a combo box for the user to select and the contents displayed in a list box. Any "show.." 
commands are displayed in a seperate text box as read only for additional testing help.

 Double click a command in the list box and it will append to a rich text box for editing
including adding user essential input as previously mentioned. To insert a command between
commands, create a new line, click once a command and hit the insert button which will 
copy at the cursor. 

 Once completed right click in the editor to copy to the clipboard ready to paste. Ctl+C 
will also work if preferred. A select all and copy option is included as well as seperate
options. 

 The config file can be constructed by switching between text files as the editor is only
cleared by selecting the "clear editor" button. Schroll bars are obviously included in all
text boxes.

 The user is free to adjust the text files holding the config/show commands or add new ones
as long as they are .txt and added to the ConfigTextFiles folder, no other extensions are 
looked for.

 Tried to keep out complexity as the original design looked fancy but was too complicated
and unnecessary. Tried to keep code short and simple with all methods in the same class.
Win Forms was chosen for construction speed and design experimentation. 

 To follow - working on appending to a .txt file and further user file control such as naming.
