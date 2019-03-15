// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import FrontpageApp from './Apps/FrontpageApp'
import Project from './Apps/Project'
import ProjectListApp from './Apps/ProjectListApp'
import GheorghesApp from './Apps/GheorghesApp'

//font-awesome icons
import { library } from '@fortawesome/fontawesome-svg-core'

import { faUsersCog, faCode, faShoppingCart } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'


library.add([faUsersCog, faCode, faShoppingCart])

Vue.component('font-awesome-icon', FontAwesomeIcon)
//--font awesome

Vue.component("FrontpageApp", FrontpageApp)
Vue.component("Project", Project)
Vue.component("ProjectList", ProjectListApp)
Vue.component("GheorgesApp", GheorghesApp)
// Vue.component("Uanimate", Uanimate)

Vue.config.productionTip = false


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
if(document.getElementById("app-gheorghe")){
  new Vue({
    el:"#app-gheorghe",
    template :"<GheorghesApp/>",
    components: {GheorghesApp}
  })
}