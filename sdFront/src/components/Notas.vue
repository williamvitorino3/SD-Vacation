<template>
  <div class="container-fluid">
    <h1>Notas</h1>

    <input type="number" class="form-control" v-model="n1">
    <input type="number" class="form-control" v-model="n2">
    <button class="btn" @click="post" >Calcular</button>
    <p v-if="situacao.length">situacao</p>
  </div>
</template>

<script>
export default {
  data () {
    return {
      n1: 0,
      n2: 0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/notas', [this.n1, this.n2]).then(
        success => {
          this.situacao = success;
          console.log(success);
        },
        err => {
          console.log(err);
        }
      )
    }
  }
}
</script>

<style scoped>

</style>
