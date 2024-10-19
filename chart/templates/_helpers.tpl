{{/*
Define a função para obter o nome do aplicativo
*/}}
{{- define "tftec-app.name" -}}
{{- .Release.Name | quote -}}
{{- end -}}

{{/*
Define a função para obter o nome completo do aplicativo
*/}}
{{- define "tftec-app.fullname" -}}
{{- printf "%s-%s" .Release.Name .Chart.Name | quote -}}
{{- end -}}
