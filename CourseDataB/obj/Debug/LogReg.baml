   M S B A M L   `   `   `  ����F  BCourseDataB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CourseDataBCourseDataB  5   	   D @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5	   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5
   	       CourseDataB.LogReg   5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CourseDataB     5   	   Efw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF     5	   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5
   	   )  #SourceChord.FluentWPF.AcrylicWindow    Enabled  .    AcrylicWindowStyle$
 None=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   $��15(�5   	   
������� � Title$ LogReg��5   	   $��573.6��6   $��302.8��6'    � AllowsTransparency . .��5      � $	��450��6   $	��Top=�6   .+�5        Dragablz.TabablzControl  $��0,0,0.4,-127q�6&      InterTabController 5      !  Dragablz.InterTabController  5      .@�5      �� $��Вход��6   .��5      �� $��Center=�6   .+�5      �� -   5         ��Name$ 
logentertb��5      $��0,0,0,10q�62   $	��250��6D   
������ )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Логин��6i    %  !MaterialDesignFloatingHintTextBox#��[  6�   
�������6  G� 5      -   5        
 G�Name$
 
pasenterpb��5      $	��250��6'   
������ 
�������$	 Пароль��5         
Foreground
 �  ��.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �  �� ) %MaterialDesignFloatingHintPasswordBox#��[ 5"      6R   �� 5#      -   5         ��Name$ enterbutton��5#      $	��100��62   $��0,10,0,0q�6>   {�.  .��6|   
Вход6�   5$      5%      �� 5&      $��Регистрация��6   .��5'      �� $��Center=�6   .+�5(      �� -   5        $ logregtb��5(      $��0,0,0,10q�60   $	��250��6B   
������ $	 
Логин��6g   #��[  6�   
�������6  G� 5)      -   5        $
 pasregpb��5*      $	��250��6%   
������ 
�������$	 Пароль��5+      
 �  ��
 �  ��#��[ 5.      6R   G� 5/      -   5        $
 pasregpbconfirm��50      $	��250��6,   
������ 
�������$��0,10,0,0q�51      $%	 Повторите пароль��52      
 �  ��
 �  ��#��[ 55      6R   �� 56      -   5        $ 	regbutton��56      $	��200��60   $��0,10,0,0q�6<   {�.  .��6x   &$Зарегистрироваться6�   57      58      59      5:      5<      