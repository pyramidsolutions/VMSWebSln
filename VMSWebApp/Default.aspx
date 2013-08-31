<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VMSWebApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="mainPH">
    <section class="featured">
       <div class="home-quotes">Unlimited skins options with its "Skin system" allows you to create new styles for your theme.</div>
			
			<!-- Slider -->
			<div id="slider">
			    <a ><img src="images/1.png" alt="" /></a>
			    <a ><img src="images/2.png" alt="" /></a>
			    <a ><img src="images/3.png" alt=""/></a>
			</div>
			<!-- ENDS Slider -->
						
			<!-- CONTENT -->
			<div id="content">
				<!-- PAGE CONTENT -->
				<div id="page-content">
					
					<!-- feature blocks -->
					<h1 class="header-line">FEATURE PAGES</h1>
					<ul  class="feature-blocks" >
						<li>
							<div class="block">
								<a href="single.html" title="Title" ><img class="cover" src="img/dummies/272x250.jpg" alt="Alt text" title="Title"/></a>
							</div>
							<div class="the-excerpt">
								Pellentesque habitant morbi tristique senectus et netus et malesuada fames.
							</div>
							<a href="single.html"  class="link-button"><span>Read more</span></a>
						</li>
						<li>
							<div class="block">
								<a href="single.html"  ><img class="cover" src="img/dummies/272x250.jpg" alt="Alt text" title="Title"/></a>
							</div>
							<div class="the-excerpt">
								Pellentesque habitant morbi tristique senectus et netus et malesuada fames.
							</div>
							<a href="single.html"  class="link-button"><span>Read more</span></a>
						</li>
						<li>
							<div class="block">
								<a href="single.html" title="Title" ><img class="cover" src="img/dummies/272x250.jpg" alt="Alt text" title="Title"/></a>
							</div>
							<div class="the-excerpt">
								Pellentesque habitant morbi tristique senectus et netus et malesuada fames.
							</div>
							<a href="single.html"  class="link-button"><span>Read more</span></a>
						</li>
						<li>
							<div class="block">
								<a href="single.html" title="Title" ><img class="cover" src="img/dummies/272x250.jpg" alt="Alt text" title="Title"/></a>
							</div>
							<div class="the-excerpt">
								Pellentesque habitant morbi tristique senectus et netus et malesuada fames.
							</div>
							<a href="single.html"  class="link-button"><span>Read more</span></a>
						</li>
					</ul>
					<!-- ENDS feature blocks -->
										
					
					<!-- TABS -->
					<!-- the tabs -->
					<ul class="tabs">
						<li><a href="#">Information</a></li>
						<li><a href="#">News</a></li>
						<li><a href="#">Recent videos</a></li>
						<li><a href="#">Latest gallery</a></li>
						
					</ul>
					
					<!-- tab "panes" -->
					<div class="panes">
					
						<!-- Information  -->
						<div>
							
							<p class="info-box">
								<img src="img/mono-icons/smile32.png" title="smile32.png" alt="smile32.png" class="alignleft" />
								Pellentesque habitant morbi ser fames turpis egestas tortor malesuada fames ete turpis egestas tortor quam, feugiat vitae.
							</p>
						
							<p class="info-box">
								<img src="img/mono-icons/boxdownload32.png" title="boxdownload32.png" alt="" class="alignleft" />
								Pellentesque habitant morbi ser fames turpis egestas tortor malesuada fames ete turpis egestas tortor quam, feugiat vitae.
							</p>
							
							<p class="info-box">
								<img src="img/mono-icons/risegraph32.png" title="risegraph32.png" alt="risegraph32.png" class="alignleft" />
								Pellentesque habitant morbi ser fames turpis egestas tortor malesuada fames ete turpis egestas tortor quam, feugiat vitae.
							</p>
							
							<p class="info-box">
								<img src="img/mono-icons/camera32.png" title="camera32.png" alt="" class="alignleft" />
								Pellentesque habitant morbi ser fames turpis egestas tortor malesuada fames ete turpis egestas tortor quam, feugiat vitae.
							</p>
						
						</div>
						<!-- ENDS Information -->
						
						<!-- Post list -->
						<div>
							<ul class="blocks-list">
								<li>
									<a href="single.html" class="border"><img src="img/dummies/114x86.jpg" alt="Post" /></a>
									<div class="the-excerpt">
										<strong>Pellentesque habitant morbi tristique</strong>  senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.																			<a href="single.html" class="link-arrow">Read more &#8594;</a>
									</div>
								</li>
								<li>
									<a href="single.html" class="border"><img src="img/dummies/114x86.jpg" alt="Post" /></a>
									<div class="the-excerpt">
										<strong>Pellentesque habitant morbi tristique</strong>  senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.																			<a href="single.html" class="link-arrow">Read more &#8594;</a>
									</div>
								</li>
								<li>
									<a href="single.html" class="border"><img src="img/dummies/114x86.jpg" alt="Post" /></a>
									<div class="the-excerpt">
										<strong>Pellentesque habitant morbi tristique</strong>  senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.																			<a href="single.html" class="link-arrow">Read more &#8594;</a>
									</div>
								</li>
							</ul>
						</div>
						<!-- ENDS Post list -->
					
						
						<!-- img gallery -->
						<div>
							<ul class="blocks-gallery">
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a class="border" href="http://www.youtube.com/watch?v=twuScTcDP_Q" title="The Video" rel="prettyPhoto"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
							</ul>
						</div>
						<!-- ENDS img gallery -->
						
						<!-- img gallery -->
						<div>
							<ul class="blocks-gallery">
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
								<li><a href="img/dummies/584x300.jpg" class="border fancybox" title="An image"><img src="img/dummies/114x86.jpg" alt="Post" /></a></li>
							</ul>
						</div>
						<!-- ENDS img gallery -->
						
					</div>
					<!-- ENDS TABS -->
					
					
					
					
				</div>
				<!-- ENDS PAGE-CONTENT -->
			
			</div>
    </section>
</asp:Content>

