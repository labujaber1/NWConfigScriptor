# NWConfigScriptor
Used .NETCore. Win Forms was chosen for easier design experimentation and construction speed.

 This is a simple win form program aimed at students learning routing who are tired of typing
in repeated configuration commands for devices. It is not a learning tool to teach routing 
configuration as Cisco and packet tracer do a great job of doing that. It is essentially a 
tool to construct config commands to copy and paste into network devices CLI. It also allows 
the config commands to be saved into a text file and the user to choose location and filename.

 Text files contain basic routing commands that are used up to level 6 (UK degree) with 
a question mark to identify additional user input. This includes ip addresses, hostnames, 
network addresses, and so forth. Text files have been chosen as they are small in size
and easier to manage in such a small program.

 The tool will only look for .txt file extensions stored in a folder "ConfigTextFiles".
 They will be listed in a combo box for the user to select and the contents displayed in a
 list box. Any "show.." commands are displayed in a seperate text box as read only for 
 additional testing help.

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
looked for. If ammending existing files they will need to be saved and the file overwritten
as the commands are only read in from a file, the file is not kept open for editing. If files 
are added while in debug mode, the file properties will need to be changed in the solution so
they are included on build. Build action change to 'content', and copy to output to 'Copy if 
newer'.
 
 Help, Load file, save file, and append to file options added to right click menu in the 
editor. The load file reads in file content into the editor for editing or appending and
so will need to overwrite existing file when saving. Append to file allows commands to be
added to files without the need for them to be opened in the editor.

In the next form and once a text file is created it can be read, line by line, to a router in
GNS3 via telnet. A VM must be used with the topolgy devices such as VMware (recommended by GNS3
documentation).
The target router must be configured with: 
�	Username gns3 password 0 gns3.
�	Ip address on interface connecting to the cloud.
�	Line vty 0 4 : transport input all; password gns3; 
�	Line console 0 : logging synchronous; password gns3; login; 
�	Enable secret gns3.
A cloud device attached to the router with the vmnet1 adapter added and an IP address for 
this also configured from the local pc. The process output is shown in a rich text box in the
form to monitor progress. 

Another option has also been included in the first form using putty to telnet/ssh to a routers
CLI provided the configurations above are completed. 

Third form  is TFTP transfer to backup config files for a user to manually change and resend back.
Included TFTPD64 as the server, commands sent directly to router. Can display config file which
then replaces the extension from .file to .cfg.
 
