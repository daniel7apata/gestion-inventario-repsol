   M S B A M L   `   `   `  ����H  DPrensentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PrensentacionPrensentacion  5   	   *    $Prensentacion.FormularioLoteSaliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Prensentacion     5   	     � Title$  FormularioLoteSaliente��5   	   $	��487��6(   $	��832��65   .��5	      � $��	0,0,10,17q�6    � ColumnDefinitions 5
   
   �� 5      $
��287* �6   �� 5      $
��109* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEsaliente��5      $
��Left=�6(   $	��186��6C   $��
360,52,0,0q�6P   $	��Top=�6d   $	��434��6|   $��2��6�   �� 5   
   -   5         ��Name$ txttipo��5      $
��Left=�6#   $��24��6>   $��	89,28,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   6�   �� 5   
   -   5        $ txtfecha_salida��5      $
��Left=�6+   $��24��6F   $��	89,76,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ 	txtciudad��5      $
��Left=�6%   $��23��6@   $��
89,123,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ 
txtalmacen��5      $
��Left=�6&   $��22��6A   $��
89,178,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   6�   �� 5   
   $
��Tipo��6   $
��Left=�6   $��	43,26,0,0q�6:   $	��Top=�6M   �� 5   
   $��Ciudad��6   $
��Left=�6!   $��
30,123,0,0q�6<   $	��Top=�6P   �� 5   
   $��Fecha��6   $
��Left=�6    $��	35,74,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $ txtcontenido��5      $
��Left=�6(   $��22��6C   $��
89,227,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   $��Almacen��6   $
��Left=�6"   $��
27,174,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Cantidad��6   $
��Left=�6#   $��
20,225,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ btnRegistrar��5      $��	Registrar��6'   $
��Left=�6;   $��
242,83,0,0q�6V   $	��Top=�6j   $��79��6�   $	��117��6�     5   
   -   5        $ 
dgCiudades��5      $
��Left=�6'   $	��100��6B   $	��Top=�6O   $	��345��6g   $��385,318,0,0q�6s   $��2��6�     5   
   -	   5        $ 	dgalmacen��5      $
��Left=�6&   $	��101��6A   $��
89,317,0,0q�6N   $	��Top=�6b   $	��222��6z   6�   �� 5   
   $!��Lotes Salientes Registrados��6   $
��Left=�66   $��
360,21,0,0q�6Q   $	��Top=�6e   �� 5   
   $��Contenido de almacenes��6   $
��Left=�61   $��
89,291,0,0q�6L   $	��Top=�6`   �� 5   
   $&�� Combustible enviado a ciudades
��6   $
��Left=�6C   $��385,291,0,0q�6^   $	��Top=�6s   $	��188��6�   $��27��6�   5       5!      