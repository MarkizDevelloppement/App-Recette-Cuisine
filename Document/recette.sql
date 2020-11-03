<ListView x:Name ="Mygrid" Margin="22,95,25,30" Background="#FFF3EDE5">
    <ListView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="30*"/>
                    <RowDefinition Height="29*"/>
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="713" />
                </Grid.ColumnDefinitions>
                <Image Height="147" VerticalAlignment="Top" Grid.Column="0" Source="{Binding url}" Margin="4,74,0,0" HorizontalAlignment="Left" Width="193"/>
                <Label VerticalAlignment="Top" Width="194" Height="49" FontFamily="Tahoma" Content="{Binding titre}" FontSize="24" Margin="4,20,515,0" HorizontalAlignment="Center" HorizontalContentAlignment="Center" BorderBrush="#FF00CB37" Padding="5" BorderThickness="1" Background="#FF98FF81"/>
                <Label HorizontalAlignment="Left" Margin="304,20,0,0" VerticalAlignment="Top" Width="163" Height="30" Content="{Binding categorie}" FontWeight="Bold" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="316,55,0,0" VerticalAlignment="Top" Width="94" Height="30" Content="{Binding tempsprepa}" FontWeight="Bold" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="584,22,0,0" VerticalAlignment="Top" Width="119" Height="30" Content="{Binding modeprepa}" FontWeight="Bold" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="584,56,0,0" VerticalAlignment="Top" Width="119" Height="30" Content="{Binding nbrperson}" FontWeight="Bold" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="304,91,0,0" VerticalAlignment="Top" Width="399" Height="93" Content="{Binding ingredient}" FontWeight="Bold" BorderBrush="#FFC1EC00" BorderThickness="1" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="304,189,0,0" VerticalAlignment="Top" Width="198" Height="30" Content="{Binding origine}" FontWeight="Bold" Background="#FF59FFAB"/>
                <Label HorizontalAlignment="Left" Margin="472,22,0,0" VerticalAlignment="Top" Width="107" Height="30" Content="Mode de prépa :" FontWeight="Bold" FontSize="11" FontStyle="Italic"/>
                <Label HorizontalAlignment="Left" Margin="459,56,0,0" VerticalAlignment="Top" Width="120" Height="30" Content="Nmbr. de personne :" FontWeight="Bold" FontSize="11" FontStyle="Italic"/>
                <Label HorizontalAlignment="Left" Margin="203,22,0,0" VerticalAlignment="Top" Width="65" Height="30" Content="Catégorie :" FontWeight="Bold" FontSize="11" FontStyle="Italic"/>
                <Label HorizontalAlignment="Left" Margin="203,56,0,0" VerticalAlignment="Top" Width="108" Height="30" Content="Temps de prépa :" FontWeight="Bold" FontSize="11" FontStyle="Italic"/>
                <Label HorizontalAlignment="Left" Margin="203,112,0,0" VerticalAlignment="Top" Width="115" Height="30" Content="Ingrédients :" FontWeight="Bold" FontSize="11" FontStyle="Italic" ScrollViewer.CanContentScroll="True"/>
                <Label HorizontalAlignment="Left" Margin="203,191,0,0" VerticalAlignment="Top" Width="83" Height="30" Content="Origine :" FontWeight="Bold" FontSize="11" FontStyle="Italic"/>
                <Rectangle HorizontalAlignment="Left" Height="240" Stroke="#FF00A6CB" VerticalAlignment="Top" Width="713"/>
            </Grid>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
