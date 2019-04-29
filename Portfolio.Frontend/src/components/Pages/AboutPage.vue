<template>
    <div class="grid-container  about-container ">
        <div class="grid-x">
            <div class="medium-4 left-column col-padding">
                 <div class="grid-x headline-container">
                        <div class="medium-12 ">
                            <h1 class="text-center">
                                <div class="stroke"></div>
                                <span>NERIJA BALAN</span>
                                <div class="stroke"></div>
                            </h1>
                        </div>
                        <div class="medium-12">
                            <h2 class="text-center">UX Designer</h2>
                        </div>
                    </div>

               <div class="grid-x">
                   <div class="large-12 about-info-col">
                        <h3>
                            Contact 
                        </h3>
                        <div class="stroke"></div>
                        <p><strong>Phone</strong>
                            <br> 2000000000
                        </p>
                        <p><strong> E-mail</strong>
                            <br/>mail@lipsum.com
                        </p>
                        <p><strong> Website</strong>
                            <br/>nerijabalan.com
                         </p>
                   </div>
               </div>

               <div class="grid-x">
                   <div class="large-12">
                        <h3>
                            Education 
                        </h3>
                        <div class="stroke"></div>
                        <p>Edu1 </p>
                        <p>Edu 2</p>
                        <p>Edu 3</p>
                   </div>
               </div>

               <div class="grid-x">
                   <div class="large-12">
                        <h3>
                            Languages 
                        </h3>
                        <div class="stroke"></div>
                        <p>Lang 1</p>
                        <p>Lang 2</p>
                        <p>Lang 3</p>
                   </div>
               </div>
            </div>
            <div class="medium-8 right-column col-padding">
           
                <div class="grid-x">
                    <div class="large-12">
                        <h3>Profile</h3>
                        <div class="stroke"></div>
                        <p>I am a UX designer with experience in researching and developing solutions
                            that meet both users’ needs and business goals. I have more than 3 years of
                            working experience with development and implamentation of product and
                            web design.</p>
                        </div>
                </div>

                <div class="grid-x">
                    <div class="large-12">
                        <h3>Experience</h3>
                        <div class="stroke"></div>
                        <h5>UX Designer, Nordija</h5>
                        <h5>January 2017 - ongoing</h5>
                        <p>I am a UX designer with experience in researching and developing solutions
                            that meet both users’ needs and business goals. I have more than 3 years of
                            working experience with development and implamentation of product and
                            web design.</p>
                            <br>

                        <h5>UX Designer, Nordija</h5>
                        <h5>January 2017 - ongoing</h5>
                        <p>I am a UX designer with experience in researching and developing solutions
                            that meet both users’ needs and business goals. I have more than 3 years of
                            working experience with development and implamentation of product and
                            web design.</p>
                            <br>
                    </div>
                </div>

                  <div class="grid-x">
                    <div class="large-12">
                        <h3>Designer's Toolbox</h3>
                        <div class="stroke"></div>
                        <p>
                            <ul>
                                <li>User Research</li>
                                <li>User testing</li>
                                <li>Flinto</li>
                                <li>Sketch</li>
                                <li>Illustrator</li>
                                <li>Adobe InDesign</li>
                                <li>Adobe Photoshop</li>
                            </ul>
                        </p>
                        </div>
                </div>

            </div>
        </div>
    </div>
</template>
<script>
import axios from "axios"

export default{
    name: 'AboutPage',
    data(){
        return {
            show:""
        };
    },
    // mounted(){
    //     axios.get("/umbraco/Api/ProjectsApi/GetFeaturedProjects?website=Nerija").then(response => {
    //         console.log(response.data.Projects);
    //         this.projects = response.data.Projects;
    //     });
    // },
    methods: {
    
    }        
 }
</script>