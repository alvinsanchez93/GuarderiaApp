   M S B A M L   `   `   `  ����  GuarderiaApp+    %GuarderiaApp.Views.GestionAlumnosView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $
��Auto��5      $
��Auto��6   .��5      � .+�5   
   �� $��Gestión de Alumnos��6   $��24(�6.   $
��Bold"�6<   $��20q�6N   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  DataGridAlumnos��5         AutoGenerateColumns .  $��20,80,20,100q�6H      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5	      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
IdAlumno+6N     5
      $ Nombre��6%   $ * 6X    65   �� *NombreCompleto+6X     5      $
 Edad��6%   $	 100 6L    63   �� *Edad+6L     5      $ Alergias��6%   $	 200 6T    67   �� *
Alergias+6T   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5      �� $��Agregar Alumno��6   $	��150��6.   $��40��6:   $��10q�6F   �� 5      $��Editar Alumno��6   $	��150��6-   $��40��69   $��10q�6E   �� 5      $��Eliminar Alumno��6   $	��150��6/   $��40��6;   $��10q�6G   5      5      5      