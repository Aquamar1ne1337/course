   M S B A M L   `   `   `  ����F  BCourseDataB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CourseDataBCourseDataB  5   	   D @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5	   	       CourseDataB.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CourseDataB     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5	   	   )  #SourceChord.FluentWPF.AcrylicWindow    Enabled  .    AcrylicWindowStyle$
 None=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   $��15(�5   	    � Title$ 
MainWindow��5   	   $	��600��6   $��412.653��6)    � AllowsTransparency . .��5      � .+�5   
   �� $	��Top=�6   $
��Left=�6-   .+�5      �� -   5         ��Name$ Closebt��5      
������ 
������ 
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$ Close=�5      $��24��5      $��24��5      5      5      �� 5   
   $��Center=�6   $��Center=�62   .+�5   
   �� -   5        	 ��Name$	 
gamenametb��5      $	��250��6&   
������ )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Название��6K    %  !MaterialDesignFloatingHintTextBox#��[  6u   
�������6�   �� 5    
   -   5        $	 covertb��5       $	��250��6#   
������ $
 Обложка��6H   #��[  6q   
�������6�   �� 5!      -   5        $	 desdb��5!       �� TextWrapping$
 Wrap=�5"      $��Stretch=�5#      $	��280��5$       �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�5&       �� 	IsEnabled . $
 Описание��5(      
�������$��80��5*      .��6   5,      �� 5-      -   5        $	 datetb��5-      $	��250��6&   
������ $
 Дата выхода��6K   #��[  6x   
�������6�   �� 5.      -   5        $	 pricetb��5.      $	��250��6'   
������ $
 Цена��6L   #��[  6r   
�������6�   �� 5/      -   5        
������ $��0,10,0,0q�5/   .   $	��250��6@   $��Добавить��6L   
�������6�   50      52      53      