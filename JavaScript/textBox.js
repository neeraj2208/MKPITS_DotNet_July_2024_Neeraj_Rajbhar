<html>
    <form name="f1">
       Enter num:<input type="text" id="n1"/><br><br>
       <button onclick="square();">Submit</button> 
    </form>
    <script language="javascript">
        function square()
        {
            var num=document.f1.n1.value;
            var square=num*num;
            document.write("Square is "+square);
        }
    </script>
</html>