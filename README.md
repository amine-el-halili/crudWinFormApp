# WinForm app 
CRUD operation on table persons (<ins>id_person</ins>, name)

# state machine diagram (Diagramme de transition d'etat)

<p align="center">
  <img src="https://user-images.githubusercontent.com/116503971/202722492-23de35f0-1a48-49aa-bb42-3dac4bff82a8.png"  width="80%">
</p>

# Code description

### state description
```
  void initialState() => initial state
```  
```
  void addState() => add state: when you want to add a new item
``` 
```
  void modifyState() => modify state: when you want to modify an item
``` 
```
  void deleteState() => delete state: when you want to delete a state
``` 
```
  void selectedState() => select state: when you select an item from the combo box
``` 

### event description (event handlers)
```
  void comboxBox_SelectedIndexChanged(object sender, EventArgs e)) => select an item from the combo box 
```  
```
  void add_btn_Click(object sender, EventArgs e)) => click at add button
``` 
```
  void modify_btn_Click(object sender, EventArgs e)) => click at modify button
``` 
```
  void delete_btn_Click(object sender, EventArgs e)) => click at delete button
```  
```
  void cancel_btn_Click(object sender, EventArgs e)) => click at cancel button
```  
