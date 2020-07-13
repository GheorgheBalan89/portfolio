<template>
    <div>
         <div v-if="project != null">
            <div v-if="project.Detail != null" class="hero-section-responsive">  
                   <div class="hero-section-text">
                        <h1>{{project.General.Title}} </h1>
                    <div class="text-center">
                       <h5> Client: {{project.Detail.ClientName}}  <br> Year: {{project.Detail.Year}} <br/> Role: {{ project.Detail.Role}}</h5> 
                     </div>
                        <div class="hero-description" v-html="project.General.Description"></div>
                    </div>
                </div>
                <div v-if="project.ContentRows !=null && row != null"  v-for="row in project.ContentRows"  :key="row.BigHeading" class="row content-row-responsive">
                   
                    <div class="grid-x">
                        <div class="cell small-12 icon-container text-center">
                             <h2 v-if="row.BigHeading != null">{{row.BigHeading}}</h2>
                            <img v-if="row.Icon != null" class="icon" :src="row.Icon" :alt="row.BigHeading || row.SmallHeading">
                            <h3 class="small-heading" v-if="row.SmallHeading != null">{{row.SmallHeading}}</h3>
                        </div>
                        <div v-if="row.TextColumnLeft != null" class="cell small-12 text">
                            <p>
                            {{row.TextColumnLeft}}
                            </p>
                        </div>
                        <div v-if="row.TextColumnRight" class="cell small-12 text">
                            <p>
                            {{row.TextColumnRight}}
                            </p>
                        </div>
                    </div>
                    <div class="grid-x">
                        <div class="cell medium-12">
                            <img class="main-image" :src="row.Image" :alt="row.BigHeading || row.SmallHeading">
                        </div>
                    </div>
                </div>  
        </div>  
    </div>
</template>


<script>
import axios from "axios"

export default{  
    name : "SingleProjectResponsive",
    props: ["project"]
}
</script>