   M S B A M L   `   `   `  ����  GuarderiaApp,    &GuarderiaApp.Views.GestionPersonalView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $
��Auto��5      $
��Auto��6   .��5      � .+�5   
   �� $��Gestión de Personal��6   $��24(�6/   $
��Bold"�6=   $��20q�6O   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  DataGridPersonal��5         AutoGenerateColumns .  $��20,80,20,100q�6I      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5	      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
IdPersonal+6P     5
      $ Nombre��6%   $ * 6X    65   �� *NombreCompleto+6X     5      $ Cargo��6%   $	 150 6N    64   �� *Cargo+6N     5      $ 	Teléfono��6%   $	 150 6T    67   �� *
Telefono+6T   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5      �� $��Agregar Personal��6   $	��150��60   $��40��6<   $��10q�6H   �� 5      $��Editar Personal��6   $	��150��6/   $��40��6;   $��10q�6G   �� 5      $��Eliminar Personal��6   $	��150��61   $��40��6=   $��10q�6I   5      5      5      