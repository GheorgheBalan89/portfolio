// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import FrontpageApp from './Apps/FrontpageApp'
import Project from './Apps/Project'
import ProjectListApp from './Apps/ProjectListApp'

Vue.config.productionTip = false
Vue.component("FrontpageApp", FrontpageApp)
Vue.component("Project", Project)
Vue.component("ProjectList", ProjectListApp)

/* eslint-disable no-new */
if(document.getElementById("app")){
  new Vue({
    el: '#app',
    components: { FrontpageApp },
    template: '<FrontpageApp/>'
  })
    
}

if(document.getElementById("project")){
  new Vue({
    el: '#project',
    template: '<Project/>',
    components: { Project }
  })
}
 
if(document.getElementById("projects")){
    new Vue({
      el: '#projects',
      template: '<ProjectListApp/>',
      components: { ProjectListApp }
  })
}