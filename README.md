VhostsEditor
============

Simple gui tool for edit  XAMPP virtual hosts on windows machines

1. Instalation
  Just copy VhostsEditorGUI.exe from ./VhostsEditor/bin/release to your xampp folder and run it
  Or you can clone the repo and compile the source by yourself

2. Usage
  You can add edit and delete vhosts records from your httpd-vhosts file.
    
  Add 
      - Add new vhost record in httpd-vhosts
      - Add new record "127.0.0.1 ServerName" in windows hosts file (Requires admin privileges sometimes)
  
  Edit
      - Edit existing vhost record in httpd-vhosts
      - Edit existing record in windows hosts file
       
  Delete
      - Delete vhost from apache conf and windows hosts file
      
  ResetApache
      - Use it to reload apache configuration

3. TODO
      - Options form
      - Language support