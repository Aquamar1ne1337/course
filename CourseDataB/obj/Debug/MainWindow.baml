   M S B A M L   `   `   `  ����F  BCourseDataB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CourseDataBCourseDataB  5   	   D @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5
   	       CourseDataB.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CourseDataB     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5
   	   )  #SourceChord.FluentWPF.AcrylicWindow    Enabled  .    AcrylicWindowStyle$
 None=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   $��15(�5   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1080��6)    � AllowsTransparency . .��5      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   � *  $SourceChord.FluentWPF.PointerTracker   Enabled . ���	#01FFFFFF.+�5      �� .+�5      �� 	 �� Orientation$	 
Horizontal=�6   .+�5      �� -   5        
 ��Name$
 CloseBt��5      ��6.   Z� ��6D   Z� .��5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   
�������6?   5!      �� 5"      -   5         ��Name$ HelloTB��5"       $��
Выход��61   $��12(�6>   $��Center=�6L   
�������6g   5#      �� 5*      $��Меню��6   $��15q�6(   $��DemiBold"�64   
�������6J   �� 5+      -   5         ��Name$ LilView��5+      $��15(�6,   
�������.@�5,      �� $��1q�6#   .��5-      �� $	 
Horizontal=�6%   .+�5.        $ CartPlus=�66   $��15q�6F   �� 5/      $��Магазин��6(   $��Center=�67   50      51      �� 52      $��1q�6#   .��53      �� $	 
Horizontal=�6%   .+�54        $
 Cart=�66   $��15q�6B   �� 55      $��Корзина��6(   $��Center=�67   56      57      �� 58      $��1q�6#   .��59      �� $	 
Horizontal=�6%   .+�5:        $ CartArrowUp=�66   $��15q�6I   �� 5;      $%��Список желаемого��6(   $��Center=�6@   5<      5=      �� 5>      $��1q�6#   .��5?      �� $	 
Horizontal=�6%   .+�5@        $ Library=�66   $��15q�6E   �� 5A      $��Библиотека��6(   $��Center=�6:   5B      5C      5D      5E      �� 5F      -   5         .  *MaterialDesignFloatingActionMiniDarkButton#��[  5G      $
��Left=�5H      $��Bottom=�6,    � ToolTip$0 *MaterialDesignFloatingActionMiniDarkButton��5I      
������ 
������ .��5J        
�������$ QuestionMarkCircleOutline=�5L      $��24��5M      $��24��5N      5O      �� 5P      -   5        $
 Reportbt��5P      #��[  5Q      $��Right=�5R      $��Bottom=�6-   $0 *MaterialDesignFloatingActionMiniDarkButton��5S      
������ 
������ .��5T        
�������$ FileChartOutline=�5V      $��24��5W      $��24��5X      5Y      �� 5Z      -   5        $
 
Pareportbt��5Z      #��[  5[      $��Right=�5\      $��Bottom=�6-   $0 *MaterialDesignFloatingActionMiniDarkButton��5]      
������ 
������ $��
0,0,40.4,0q�6k   .��5^        
�������$ FileDocumentEditOutline=�5`      $��24��5a      $��24��5b      5c      5d      � 5e   
   -   5         �Name$ 	Framegrid��5e      $��1��6"    . ���	#01FFFFFF6l   5f      5h      