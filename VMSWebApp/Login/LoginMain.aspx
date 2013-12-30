<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="~/Login/LoginMain.aspx.cs" Inherits="VMSWebApp.Login.LoginMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
    <div class="container">
        <!-- Codrops top bar -->
        <div class="codrops-top">

            <div class="clr"></div>
        </div>
        <!--/ Codrops top bar -->
        <header>
            <h1>MVS Login Form </h1>

        </header>
        <section>
            <div id="container_demo">
                <!-- hidden anchor to stop jump http://www.css3create.com/Astuce-Empecher-le-scroll-avec-l-utilisation-de-target#wrap4  -->
                <a class="hiddenanchor" id="toregister"></a>
                <a class="hiddenanchor" id="tologin"></a>
                <div id="wrapper">
                    <div id="login" class="animate form">
                        
                            <h1>Log in</h1>
                            <p>
                                <label for="username" class="uname" data-icon="u">Your email or username </label>
                                <input id="username" name="username" runat="server" required="required" type="text" placeholder="myusername or mymail@mail.com" />
                            </p>
                            <p>
                                <label for="password" class="youpasswd" data-icon="p">Your password </label>
                                <input id="password" name="password" runat="server" required="required" type="password" placeholder="eg. X8df!90EO" />
                            </p>
                            <p class="login button">
                                <asp:Button  Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_ServerClick" CausesValidation="true"/>
                            </p>
                            <p class="change_link">
                                Forgot your password ?
									<a href="#toregister" class="to_register" runat="server" id="btnForgotPassword">Click here</a>
                            </p>
                        
                    </div>



                </div>
            </div>
        </section>
    </div>
</body>
</asp:Content>
