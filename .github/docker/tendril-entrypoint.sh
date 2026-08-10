#!/bin/sh
TENDRIL_HOME="${TENDRIL_HOME:-/data/tendril}"
mkdir -p "$TENDRIL_HOME"
if [ ! -f "$TENDRIL_HOME/config.yaml" ] && [ -f /etc/tendril/example.config.yaml ]; then
    cp /etc/tendril/example.config.yaml "$TENDRIL_HOME/config.yaml"
fi
exec tendril --web
