   M S B A M L   `   `   `  ����H  DPrensentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PrensentacionPrensentacion  5   	   *    $Prensentacion.FormularioLoteEntrante   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Prensentacion     5   	     � Title$  FormularioLoteEntrante��5   	   $	��402��6(   $	��728��65   .��5	      � $��-31,0,-348,18q�6    � ColumnDefinitions 5
   
   �� 5      $	��13* �6   �� 5      $	��40* �6   �� 5      $
��343* �6   .+�5   
   �� -   5         ��Name$ btnregistrar��5      $��	Registrar��6'   $
��Left=�6;   $��
155,36,0,0q�6V   $	��Top=�6j   $	��105��6�   $��2��6�   $	��113��6�   �� 5   
   -   5         ��Name$ txtcontenido��5      $
��Left=�6(   $��23��6C   $��	19,36,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��2��6�   6�   �� 5   
   -   5        $ txtfecha��5      $
��Left=�6$   $��23��6?   $��	19,64,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��2��6�   �� 5   
   -   5        $ txttipo��5      $
��Left=�6#   $��23��6>   $��	19,95,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��2��6�   �� 5   
   -   5        $ txtID_amacen��5      $
��Left=�6(   $��23��6C   $��
19,126,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��2��6�   �� 5   
   $��Cantidad��6   $
��Left=�6#   $��	36,35,0,0q�6>   $	��Top=�6Q   $��1��6i   $��60��6y   �� 5   
   $��Fecha entrada��6   $
��Left=�6(   $��	36,61,0,0q�6C   $	��Top=�6V   $��84��6n   $��2��6y   $��1��6�   �� 5   
   $
��Tipo��6   $
��Left=�6   $��	36,92,0,0q�6:   $	��Top=�6M   $��1��6e   $��34��6u   �� 5   
   $��ID Almacén��6   $
��Left=�6%   $��
36,123,0,0q�6@   $	��Top=�6T   $��1��6l   �� 5   
   $��Contenido de Almacenes��6   $
��Left=�61   $��117,187,0,0q�6L   $	��Top=�6a   $	��149��6y   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dtalmacen��5      $
��Left=�6&   $	��126��6A   $��117,213,0,0q�6N   $	��Top=�6c   $	��143��6{   $��2��6�     5   
   -   5        $ 
dgentrante��5      $
��Left=�6'   $	��288��6B   $��
292,56,0,0q�6O   $	��Top=�6c   $	��281��6{   $��2��6�   �� 5   
   $!��Lotes Entrantes Registrados��6   $
��Left=�66   $��
292,30,0,0q�6Q   $	��Top=�6e   $	��172��6}   $��2��6�   5      5      