
//Password Hiden or Show
<script type="text/javascript">
    $(function () {
        $("#toggle_pwd").click(function () {
            $(this).toggleClass("fa-eye fa-eye-slash");
            var type = $(this).hasClass("fa-eye-slash") ? "text" : "password";
            $("#Password").attr("type", type);
        });
        });
</script>
